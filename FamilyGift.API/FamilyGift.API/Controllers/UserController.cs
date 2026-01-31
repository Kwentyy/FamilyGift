using FamilyGift.API.Models.Dtos.User;
using FamilyGift.API.Models.Entities;
using FamilyGift.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FamilyGift.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<string> { "User1", "User2", "User3" };
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = $"User{id}";
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            // use automapper
            var user = new User
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName
            };
            await _userRepository.AddUser(user);
            // Logic to create a user

            return CreatedAtAction(nameof(GetUserById), new { id = 4 }, user);
        }
    }
}
