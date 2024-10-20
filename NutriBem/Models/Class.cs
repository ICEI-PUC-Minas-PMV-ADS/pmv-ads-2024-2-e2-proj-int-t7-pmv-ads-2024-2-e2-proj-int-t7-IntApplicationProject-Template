using Humanizer;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

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
        public Usuario(string nome, string email, DateOnly dataNascimento, string senha, int cpf, int telefone)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Senha = senha;
            Cpf = cpf;
            Telefone = telefone;

        }
    }

    public class Paciente : Usuario
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        public bool Pagante { get; set; }

        public Paciente(double altura, double peso) : base (Nome, Email, DataNascimento, Senha, Cpf, Telefone)
        {
            Altura = altura;
            Peso = peso;
        }
    }

    public class Nutricionista : Usuario
    {
        public double Crm { get; set; }

        public Nutricionista(double crm) : base(Nome, Email, DataNascimento, Senha, Cpf, Telefone)
        {
            Crm = crm;
        }
    }

}
