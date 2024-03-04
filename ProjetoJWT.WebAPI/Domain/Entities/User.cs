using System.ComponentModel.DataAnnotations;

namespace ProjetoJWT.WebAPI.Domain.Entities
{
    public class User : baseEntity
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }

        public User(){}

        public User(string cPF, string name, string email, string senha, string role)
        {
            CPF = cPF ?? throw new ArgumentException("CPF necessário");
            Name = name ?? throw new ArgumentException("Nome necessário");
            Email = email ?? throw new ArgumentException("Email necessário");
            Senha = senha ?? throw new ArgumentException("Senha necessário");
            Role = role ?? throw new ArgumentException("Role necessário");
        }
    }
}
