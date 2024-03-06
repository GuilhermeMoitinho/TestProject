using ProjetoJWT.WebAPI.Application.DTOs.InputModel;
using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Application.DTOs.ExtensionsInputModel
{
    public static class AuthExtensionsInputModel
    {
        public static User AuthTransformarEmEntity(this AuthInputModel inputModedl)
        {
            var user = new User()
            {
                CPF = inputModedl.CPF,
                Name = inputModedl.Name,
                Email = inputModedl.Email,
                Senha = inputModedl.Senha,
                Role = inputModedl.Role
            };

            return user;
        }
    }
}
