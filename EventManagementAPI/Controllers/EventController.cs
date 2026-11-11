using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // In-memory list to store events
        private static readonly List<Event> _events = new List<Event>();

        // Allow TicketsController to access events later
        public static IReadOnlyList<Event> GetEvents()
        {
            return _events.AsReadOnly();
        }

        // POST: api/events
        [Authorize(Roles = "Admin,Event Manager")]
        [HttpPost]
        public IActionResult CreateEvent(Event newEvent)
        {
            // Validate event information
            if (string.IsNullOrWhiteSpace(newEvent.Name) ||
                string.IsNullOrWhiteSpace(newEvent.Venue) ||
                string.IsNullOrWhiteSpace(newEvent.Genre))
            {
                return BadRequest("Name, Venue, and Genre are required.");
            }

            // Make sure the event date is in the future
            if (newEvent.Date <= DateTime.UtcNow)
            {
                return BadRequest("Event date must be in the future.");
            }

            // Make sure ticket count is valid
            if (newEvent.AvailableTickets < 0)
            {
                return BadRequest("Available tickets cannot be negative.");
            }

            // Assign a unique ID
            newEvent.Id = _events.Count == 0
                ? 1
                : _events.Max(e => e.Id) + 1;

            // Save event
            _events.Add(newEvent);

            return Ok(new
            {
                Message = "Event created successfully!",
                Event = newEvent
            });
        }

        // GET: api/events
        [HttpGet]
        public IActionResult GetUpcomingEvents()
        {
            var upcomingEvents = _events
                .Where(e => e.Date > DateTime.UtcNow)
                .OrderBy(e => e.Date)
                .ToList();

            return Ok(upcomingEvents);
        }
    }
}