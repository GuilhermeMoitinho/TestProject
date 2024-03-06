using ProjetoJWT.WebAPI.Application.DTOs.InputModel;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.ServiceResponse;

namespace ProjetoJWT.WebAPI.Domain.interfaces
{
    public interface IUserRepository 
    {
        Task AddUserAsync(User user);
        Task<string> Login(LoginInputModel user);
        Task<bool> UsuarioExistente(User user);
    }
}
