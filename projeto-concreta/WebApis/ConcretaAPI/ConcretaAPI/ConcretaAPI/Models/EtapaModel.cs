using System.ComponentModel.DataAnnotations;

namespace ConcretaAPI.Models
{
    public class EtapaModel
    {
        [Key]
        public int IdEtapa { get; set; }

        [Required]
        public required string NomeEtapa { get; set; }  

        [Required]
        public required string Descricao { get; set; }  

        public DateTime DataConclusao { get; set; }  

        public int IdObra { get; set; }  // Chave estrangeira para a Obra (relacionando com o Cadastro da Obra)

        public ObraModel? Obra { get; set; }  // Navegação para o modelo Obra
    }
}

