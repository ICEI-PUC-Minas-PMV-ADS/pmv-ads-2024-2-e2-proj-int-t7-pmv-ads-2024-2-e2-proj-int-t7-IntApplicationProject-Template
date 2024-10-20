namespace NutriBem.Models
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Senha { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
    }

    public class Paciente : Usuario
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        public bool Pagante { get; set; }


    }

}
