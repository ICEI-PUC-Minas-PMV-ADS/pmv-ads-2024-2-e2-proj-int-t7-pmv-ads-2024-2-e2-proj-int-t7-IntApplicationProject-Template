using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriBem.Models
{
    public class Refeicao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo de refeição")]
        public string Tiporefeicao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo o horário")]
        public DateOnly Horario { get; set; }

        [ForeignKey("ReceitaId")]
        public Receita Receita { get; set; }

        [ForeignKey("PlanoAlimentarId")]
        public virtual PlanoAlimentar PlanoAlimentar { get; set;}
    }
}
