using Microsoft.EntityFrameworkCore;
using ProjetoJWT.WebAPI.Application.DTOs;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Data.db;
using ProjetoJWT.WebAPI.Domain.Entities;
using ProjetoJWT.WebAPI.Domain.interfaces;
using ProjetoJWT.WebAPI.ServiceResponse;

namespace ProjetoJWT.WebAPI.Data.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly ITokenService _token;
        private readonly IUnitOfWork _unitOfWork;

        public UserRepository(AppDbContext context, ITokenService token, IUnitOfWork unitOfWork)
        {
            _context = context;
            _token = token;
            _unitOfWork = unitOfWork;
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Response> Login(UserInputModel user)
        {
            var usuario = await _context.Users.FirstOrDefaultAsync
                    (op => op.Email == user.Email && op.Senha == user.Senha);

            var token = _token.GerarToken(usuario);

            var response = new Response()
            {
                Mensagem = "Ok!",
                Dados = token,
                Sucesso = true
            };

            return response;
        }
    }
}
