using ProjetoJWT.WebAPI.Domain.Entities;

namespace ProjetoJWT.WebAPI.Application.interfaces
{
    public interface ITokenService
    {
        string GerarToken(User user);
    }
}
