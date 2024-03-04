namespace ProjetoJWT.WebAPI.Application.DTOs
{
    public class UserInputModel
    {
        public Guid Id { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public UserInputModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
