
using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI1;

namespace MusicRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        // Add music
        [HttpPost]
        public IActionResult AddMusic(Music music)
        {
            if (string.IsNullOrWhiteSpace(music.Title) ||
                string.IsNullOrWhiteSpace(music.Artist) ||
                music.Year <= 0)
                return BadRequest("Enter valid album information");

            music.Id = MusicStore.MusicList.Count == 0
                ? 1 : MusicStore.MusicList.Max(x => x.Id) + 1;

            music.Available = true;
            MusicStore.MusicList.Add(music);

            return Ok("Music added successfully");
        }

        // View music
        [HttpGet]
        public IActionResult GetMusic()
        {
            return Ok(MusicStore.MusicList);
        }

        // Delete music
        [HttpDelete("{id}")]
        public IActionResult DeleteMusic(int id)
        {
            var music = MusicStore.MusicList
                .FirstOrDefault(x => x.Id == id);

            if (music == null)
                return NotFound("Music not found");

            if (!music.Available)
                return BadRequest("Cannot delete rented music");

            MusicStore.MusicList.Remove(music);

            return Ok("Music deleted");
        }
    }
}
