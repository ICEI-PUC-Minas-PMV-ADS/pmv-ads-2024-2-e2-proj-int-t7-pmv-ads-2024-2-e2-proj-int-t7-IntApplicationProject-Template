namespace ConcretaAPI.DTOs
{
    public class EtapaDTO
    {
        public int IdEtapa { get; set; }
        public required string NomeEtapa { get; set; }
        public required string Descricao { get; set; }
        public DateTime DataConclusao { get; set; }
        public int IdObra { get; set; }  // ID da Obra 
    }
}
