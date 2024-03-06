namespace ProjetoJWT.WebAPI.Application.DTOs.InputModel
{
    public class LoginInputModel
    {
        public Guid Id { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public LoginInputModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
