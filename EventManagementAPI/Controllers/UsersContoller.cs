using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using EventManagementAPI;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // In-memory list to store registered users
        private static readonly List<User> _users = new List<User>();

        // Password hasher
        private readonly PasswordHasher<User> _passwordHasher =
            new PasswordHasher<User>();

        // Allow AuthController to access registered users
        public static IReadOnlyList<User> GetUsers()
        {
            return _users.AsReadOnly();
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            // Check if required fields are missing
            if (string.IsNullOrWhiteSpace(request.Name) ||
                string.IsNullOrWhiteSpace(request.Email) ||
                string.IsNullOrWhiteSpace(request.Password))
            {
                return BadRequest("Name, Email, and Password are required.");
            }

            // Normalize email
            string email = request.Email.Trim().ToLowerInvariant();

            // Check if email already exists
            if (_users.Any(x => x.Email == email))
            {
                return BadRequest("Email already exists.");
            }

            // Create a new user
            var user = new User
            {
                Id = _users.Count + 1,
                Name = request.Name.Trim(),
                Email = email,
                Role = email == "admin@example.com" ? "Admin" : "User"
            };

            // Hash password
            user.PasswordHash = _passwordHasher.HashPassword(
                user,
                request.Password
            );

            // Add user to the in-memory list
            _users.Add(user);

            return Ok(new
            {
                Message = "Registration successful!",
                UserId = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role
            });
        }
    }
}