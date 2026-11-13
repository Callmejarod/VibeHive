using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TicketsController : ControllerBase
    {
        // In-memory list of booked tickets
        private static readonly List<Ticket> _tickets = new List<Ticket>();

        // POST: api/tickets
        [HttpPost]
        public IActionResult BookTicket(int eventId)
        {
            // Get the logged-in user's ID from their JWT
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null ||
                !int.TryParse(userIdClaim.Value, out int userId))
            {
                return Unauthorized("Invalid user token.");
            }

            // Find the event
            var musicEvent = EventsController.GetEvents()
                .FirstOrDefault(e => e.Id == eventId);

            if (musicEvent == null)
            {
                return NotFound("Event not found.");
            }

            // Check if tickets are available
            if (musicEvent.AvailableTickets <= 0)
            {
                return BadRequest("No tickets available.");
            }

            // Create a new ticket
            var ticket = new Ticket
            {
                Id = _tickets.Count + 1,
                EventId = eventId,
                UserId = userId,
                Status = "Booked"
            };

            // Reduce the available ticket count
            musicEvent.AvailableTickets--;

            // Save the ticket
            _tickets.Add(ticket);

            return Ok(new
            {
                Message = "Ticket booked successfully!",
                Ticket = ticket
            });
        }

        // GET: api/tickets/{userId}
        [HttpGet("{userId}")]
        public IActionResult GetUserTickets(int userId)
        {
            // Get the logged-in user's ID
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null ||
                !int.TryParse(userIdClaim.Value, out int loggedInUserId))
            {
                return Unauthorized("Invalid user token.");
            }

            // Prevent users from viewing other users' tickets
            if (loggedInUserId != userId &&
                !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            // Find all booked tickets belonging to the user
            var userTickets = _tickets
                .Where(t => t.UserId == userId && t.Status == "Booked")
                .ToList();

            return Ok(userTickets);
        }
    }
}