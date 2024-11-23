using System.ComponentModel.DataAnnotations;

namespace ConcretaAPI.Models
{
    public class ObraModel
    {
        [Key]
        public int IdObra { get; set; }

        [Required]
        public required string Nome { get; set; }
        public required string Construtora { get; set; }
        public required string Localizacao { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int IdUf { get; set; }        // Referência à Unidade Federativa (UF)
        public ICollection<EtapaModel> Etapas { get; set; } = new List<EtapaModel>();

        public bool EstaConcluido { get; set; } = false;

        public int IdUsuario { get; set; } // Relacionamento com o usuário

    }

}
