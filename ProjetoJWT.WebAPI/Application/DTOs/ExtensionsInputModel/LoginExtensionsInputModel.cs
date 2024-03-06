using ProjetoJWT.WebAPI.Application.DTOs.InputModel;
using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Application.DTOs.ExtensionsInputModel
{
    public static class LoginExtensionsInputModel
    {
        public static User TransformarEmUsusuario(this LoginInputModel inputModel)
        {
            var user = new User()
            {
                Email = inputModel.Email,   
                Senha = inputModel.Senha,   
            };

            return user;
        }
    }
}
