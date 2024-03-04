using Microsoft.AspNetCore.Mvc;
using ProjetoJWT.WebAPI.Application.DTOs;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (user == null) return BadRequest();  

            await _userService.AddUserAsync(user);

            return Ok();
        }

        [HttpPost("login", Name = "login")]
        public async Task<IActionResult> Login(UserInputModel user)
        {
            if(user == null) return NotFound();

            var response = await _userService.Login(user);

            return Ok(response);    
        }
    }
}
