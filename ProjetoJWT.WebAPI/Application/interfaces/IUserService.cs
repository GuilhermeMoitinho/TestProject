using ProjetoJWT.WebAPI.Application.DTOs;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.ServiceResponse;

namespace ProjetoJWT.WebAPI.Application.interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<Response> Login(UserInputModel user);
    }
}
