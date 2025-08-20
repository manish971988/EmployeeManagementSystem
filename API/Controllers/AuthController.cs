using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null || !VerifyPassword(dto.Password, user.PasswordHash))
                return Unauthorized();
            // For demo, return a dummy token
            return Ok(new { token = "dummy-jwt-token" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserLoginDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.Password))
                return BadRequest("Email and password are required.");

            var exists = await _context.Users.AnyAsync(u => u.Email == dto.Email);
            if (exists)
                return Conflict("User already exists.");

            var user = new User
            {
                Email = dto.Email,
                PasswordHash = HashPassword(dto.Password)
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        private bool VerifyPassword(string password, string hash)
        {
            if (password == null || hash == null) return false;
            using var sha256 = SHA256.Create();
            var hashed = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
            return hashed == hash;
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password ?? "")));
        }
    }

    public class UserLoginDto
    {
    public string? Email { get; set; }
    public string? Password { get; set; }
    }
}
