namespace ConcretaAPI.DTOs
{
    public class ObraDTO
    {
        public int IdObra { get; set; }
        public string Nome { get; set; }
        public string Construtora { get; set; }
        public string Localizacao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int IdGestor { get; set; }   // Relacionamento com o Gestor da Obra
        public int IdUf { get; set; }       // Relacionamento com UF
        public string? ArquivoFoto { get; set; }   // O arquivo da foto em formato binário
        public int? IdArquivoFoto { get; set; }   // Identificador opcional do arquivo da foto
    }

}
