using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriBem.Models
{
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Obrigatório informar o Nome da receita!")]
        [Display(Name = "Nome da Receita")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os Ingredientes e suas quantidades!")]
        [Display(Name = "Ingredientes e suas quantidades")]
        public string IngredienteQuantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Modo de Preparo!")]
        [Display(Name = "Modo de preparo")]
        public string MododePreparo { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as Calorias!")]
        public int Calorias { get; set; }

        public int Curtidas { get; set; }
    }
}
