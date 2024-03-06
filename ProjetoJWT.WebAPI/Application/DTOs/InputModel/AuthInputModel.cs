namespace ProjetoJWT.WebAPI.Application.DTOs.InputModel
{
    public class AuthInputModel
    {
        public Guid Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }

        public AuthInputModel()
        {
        }

        public AuthInputModel(Guid id, string cPF, string name, string email, string senha, string role)
        {
            Id = Guid.NewGuid();
            CPF = cPF;
            Name = name;
            Email = email;
            Senha = senha;
            Role = role;
        }
    }
}
