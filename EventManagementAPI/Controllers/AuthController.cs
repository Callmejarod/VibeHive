using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // JWT secret key
        private readonly string _secretKey;

        // Password hasher
        private readonly PasswordHasher<User> _passwordHasher =
            new PasswordHasher<User>();

        public AuthController(IConfiguration configuration)
        {
            _secretKey = configuration["Jwt:SecretKey"]
                ?? throw new InvalidOperationException(
                    "JWT secret key is missing.");
        }

        // POST: api/auth/login
        [HttpPost("login")]
        public IActionResult Login(LoginRequest userLogin)
        {
            // Find the user by email
            var user = UsersController.GetUsers()
                .FirstOrDefault(x =>
                    x.Email == userLogin.Email.Trim().ToLowerInvariant());

            // Check if the user exists
            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            // Verify password
            var result = _passwordHasher.VerifyHashedPassword(
                user,
                user.PasswordHash,
                userLogin.Password
            );

            if (result == PasswordVerificationResult.Failed)
            {
                return Unauthorized("Invalid email or password.");
            }

            // Create JWT token handler
            var tokenHandler = new JwtSecurityTokenHandler();

            // Convert secret key to bytes
            var key = Encoding.UTF8.GetBytes(_secretKey);

            // Configure JWT token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role)
                }),

                // Token expires after one hour
                Expires = DateTime.UtcNow.AddHours(1),

                // Sign JWT using secret key
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            // Generate JWT token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // Convert token to string
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new
            {
                Message = "Login successful!",
                Token = tokenString
            });
        }

        [Authorize]
        [HttpGet("test")]
        public IActionResult TestAuth()
        {
            return Ok("You are authenticated!");
        }
    }
}