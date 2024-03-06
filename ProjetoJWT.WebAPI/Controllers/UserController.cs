using Microsoft.AspNetCore.Mvc;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Application.DTOs.ExtensionsInputModel;
using ProjetoJWT.WebAPI.Application.DTOs.ExtensionsInputModel;
using ProjetoJWT.WebAPI.ServiceResponse;
using ProjetoJWT.WebAPI.Application.DTOs.InputModel;

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
        public async Task<IActionResult> CreateUser(AuthInputModel inputModel)
        {
            var user =  inputModel.AuthTransformarEmEntity();

            var usuarioExistente = await _userService.UsuarioExistente(user);

            if (usuarioExistente == false) return BadRequest();

            await _userService.AddUserAsync(user);

            return Ok();
        }

        [HttpPost("login", Name = "login")]
        public async Task<IActionResult> Login(LoginInputModel inputModel)
        {
            var user = inputModel.TransformarEmUsusuario();

            var usuarioExistente = await _userService.UsuarioExistente(user);

            if(inputModel == null || usuarioExistente == false) return NotFound(); 

            var token = await _userService.Login(inputModel);

            var response = new Response()
            {
                Mensagem = "Tudo certo!",
                Dados = token,
                Sucesso = true
            };

            return Ok(response);    
        }
    }
}
