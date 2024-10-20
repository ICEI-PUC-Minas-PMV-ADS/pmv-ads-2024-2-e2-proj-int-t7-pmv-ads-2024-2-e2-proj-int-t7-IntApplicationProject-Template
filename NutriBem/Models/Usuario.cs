using Humanizer;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        private readonly int _Cpf;

        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        public required int Telefone { get; set; }

        public Usuario(
            string nome, 
            string email, 
            DateOnly dataNascimento, 
            string senha, 
            int cpf, 
            int telefone
        )
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Senha = senha;
            _Cpf = cpf;
            Telefone = telefone;
        }
    }

    [Table("Paciente")]
    public class Paciente : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar a altura")]
        public required double Altura { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o peso")]
        public required double Peso { get; set; }

        public bool Pagante { get; set; }


        [ForeignKey("CpfNutricionista")]
        public int CpfNutricionista {get; set;}
        
        public Nutricionista Nutricionista {  get; set; }

        public Paciente(
            double altura, double peso, string nome, string email, 
            DateOnly dataNascimento, string senha, int cpf, int telefone
           ) : 
            base (nome, email, dataNascimento, senha, cpf, telefone)
        {
            Altura = altura;
            Peso = peso;
        }
    }

    [Table("Nutricionista")]
    public class Nutricionista : Usuario
    {
        [Required(ErrorMessage = "Obrigatório informar o CRM")]
        private readonly double _Crm;

        public ICollection<Paciente> Pacientes {get; set;}

    public Nutricionista(
            double crm, string nome, string email, DateOnly dataNascimento, string senha, int cpf, int telefone
        ) :
            base(nome, email, dataNascimento, senha, cpf, telefone)
        {
            _Crm = crm;
        }
    }

}
