namespace ProjetoJWT.WebAPI.Domain.Entities
{
    public class Employee : baseEntity
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public bool Ativo { get; set; }

        public Employee() {}

        public Employee(string nome, double salario, bool ativo)
        {
            Nome = nome ?? throw new ArgumentException("");
            Salario = salario;
            Ativo = ativo;
        }
    }
}
