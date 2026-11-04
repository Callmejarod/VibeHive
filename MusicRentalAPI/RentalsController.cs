
using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI1;

namespace MusicRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        // Rent music
        [HttpPost]
        public IActionResult RentMusic(Rental rental)
        {
            var music = MusicStore.MusicList
                .FirstOrDefault(x => x.Id == rental.AlbumID);

            if (music == null)
                return NotFound("Music not found");

            if (!music.Available)
                return BadRequest("Music already rented");

            if (rental.UserID <= 0)
                return BadRequest("Valid UserID required");

            rental.Id = MusicStore.RentalList.Count == 0
                ? 1 : MusicStore.RentalList.Max(x => x.Id) + 1;

            rental.RentalDate = DateTime.Now;
            rental.ReturnDate = null;

            music.Available = false;

            MusicStore.RentalList.Add(rental);

            return Ok("Music rented successfully");
        }

        // View active rentals
        [HttpGet]
        public IActionResult GetRentals()
        {
            var rentals = MusicStore.RentalList
                .Where(x => x.ReturnDate == null);

            return Ok(rentals);
        }

        // Return music
        [HttpPost("{id}/return")]
        public IActionResult ReturnMusic(int id)
        {
            var rental = MusicStore.RentalList
                .FirstOrDefault(x => x.Id == id &&
                                     x.ReturnDate == null);

            if (rental == null)
                return NotFound("Rental not found");

            rental.ReturnDate = DateTime.Now;

            var music = MusicStore.MusicList
                .FirstOrDefault(x => x.Id == rental.AlbumID);

            if (music != null)
                music.Available = true;

            return Ok("Music returned successfully");
        }
    }
}

