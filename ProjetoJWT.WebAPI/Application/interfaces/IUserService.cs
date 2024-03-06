using ProjetoJWT.WebAPI.Application.DTOs.InputModel;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.ServiceResponse;

namespace ProjetoJWT.WebAPI.Application.interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<string> Login(LoginInputModel user);
        Task<bool> UsuarioExistente(User user);
    }
}
