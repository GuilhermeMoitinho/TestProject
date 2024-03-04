using ProjetoJWT.WebAPI.Application.DTOs;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.ServiceResponse;

namespace ProjetoJWT.WebAPI.Domain.interfaces
{
    public interface IUserRepository 
    {
        Task AddUserAsync(User user);
        Task<Response> Login(UserInputModel user);
    }
}
