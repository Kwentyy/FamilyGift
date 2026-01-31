using AutoMapper;
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
        private readonly IMapper _mapper;
        public UserController(IUserRepository userRepository, IMapper mapper) {
            _userRepository = userRepository;
            _mapper = mapper;
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
            var user = _mapper.Map<User>(createUserDto);
            await _userRepository.AddUser(user);
            // Logic to create a user

            return CreatedAtAction(nameof(GetUserById), new { id = 4 }, user);
        }
    }
}
