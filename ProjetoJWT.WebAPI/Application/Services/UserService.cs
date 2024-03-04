using ProjetoJWT.WebAPI.Application.DTOs;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.Domain.interfaces;
using ProjetoJWT.WebAPI.ServiceResponse;

namespace ProjetoJWT.WebAPI.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task AddUserAsync(User user)
        {
            await _repository.AddUserAsync(user);
        }

        public async Task<Response> Login(UserInputModel user)
        {
            return await _repository.Login(user);
        }
    }
}
