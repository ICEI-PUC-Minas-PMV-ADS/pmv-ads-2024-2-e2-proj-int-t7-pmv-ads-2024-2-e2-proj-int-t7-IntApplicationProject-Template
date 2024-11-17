using ConcretaAPI.Models;
using ConcretaAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConcretaAPI.Data;

namespace ConcretaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapaModelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EtapaModelController(AppDbContext context)
        {
            _context = context;
        }

        // Método para adicionar uma nova Etapa
        [HttpPost("cadastrar")]
        public async Task<ActionResult<EtapaDTO>> PostEtapa(EtapaDTO etapaDto)
        {
            var etapa = new EtapaModel
            {
                NomeEtapa = etapaDto.NomeEtapa,
                Descricao = etapaDto.Descricao,
                DataConclusao = etapaDto.DataConclusao,
                IdObra = etapaDto.IdObra
            };

            _context.Etapas.Add(etapa);
            await _context.SaveChangesAsync();

            etapaDto.IdEtapa = etapa.IdEtapa;

            return CreatedAtAction("GetEtapa", new { id = etapaDto.IdEtapa }, etapaDto);
        }

        // Método para listar as etapas de uma obra
        [HttpGet("obras/{idObra}/etapas")]
        public async Task<ActionResult<IEnumerable<EtapaDTO>>> GetEtapasByObra(int idObra)
        {
            var etapas = await _context.Etapas
                .Where(etapa => etapa.IdObra == idObra)
                .ToListAsync();

            if (etapas == null)
            {
                return NotFound();
            }

            var etapasDto = etapas.Select(etapa => new EtapaDTO
            {
                IdEtapa = etapa.IdEtapa,
                NomeEtapa = etapa.NomeEtapa,
                Descricao = etapa.Descricao,
                DataConclusao = etapa.DataConclusao,
                IdObra = etapa.IdObra
            }).ToList();

            return etapasDto;
        }
    }
}
