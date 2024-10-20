using Humanizer;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;

namespace NutriBem.Models
{
    public abstract class Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento")]
        public required DateOnly DataNascimento { get; set; }
        public string Senha { get; set; }
        [Key]
        [Required(ErrorMessage = "Obrigatório informar o CPF")]
        public required int Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public required int Telefone { get; set; }

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
        [Required(ErrorMessage = "Obrigatório informar a altura")]
        public required double Altura { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o peso")]
        public required double Peso { get; set; }
        
        public bool Pagante { get; set; }

        public Paciente(
            double altura, double peso, string nome, string email, 
            DateOnly dataNascimento, string senha, int cpf, int telefone
           ) : 
            base (
                nome, email, dataNascimento, senha, cpf, telefone
            )
        {
            Altura = altura;
            Peso = peso;
        }
    }

    public class Nutricionista : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o CRM")]
        public required double Crm { get; set; }

        public Nutricionista(
            double crm, string nome, string email, DateOnly dataNascimento, string senha, int cpf, int telefone
        ) : 
            base (nome, email, dataNascimento, senha, cpf, telefone)
        {
            Crm = crm;
        }
    }

}
