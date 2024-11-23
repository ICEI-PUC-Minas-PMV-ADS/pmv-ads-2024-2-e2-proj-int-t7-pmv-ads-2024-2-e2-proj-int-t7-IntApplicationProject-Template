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
            // Cria um novo modelo de Etapa a partir do DTO
            var etapa = new EtapaModel
            {
                NomeEtapa = etapaDto.NomeEtapa,
                Descricao = etapaDto.Descricao,
                DataConclusao = etapaDto.DataConclusao,
                IdObra = etapaDto.IdObra
            };

            // Adiciona a nova etapa ao contexto do banco de dados
            _context.Etapas.Add(etapa);
            await _context.SaveChangesAsync();

            // Atribui o ID da etapa criada ao DTO
            etapaDto.IdEtapa = etapa.IdEtapa;

            return Ok(new { mensagem = "Etapa cadastrada com sucesso!", id = etapaDto.IdEtapa, etapaDto });
        }

        // Método para listar as etapas de uma obra específica
        [HttpGet("obras/{idObra}/etapas")]
        public async Task<ActionResult<IEnumerable<EtapaDTO>>> GetEtapasByObra(int idObra)
        {
            var etapas = await _context.Etapas
                .Where(etapa => etapa.IdObra == idObra)
                .ToListAsync();

            // Retorna erro 404 caso não encontre etapas para a obra
            if (etapas == null || !etapas.Any())
            {
                return NotFound();
            }

            // Converte as etapas para DTOs antes de retornar
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

        // Editar uma etapa existente
        [HttpPut("editar/{id}")]
        public async Task<IActionResult> PutEtapa(int id, EtapaDTO etapaDto)
        {
            // Verifica se a etapa existe
            var etapaExistente = await _context.Etapas.FindAsync(id);

            if (etapaExistente == null)
            {
                // Retorna erro 404 se a etapa não for encontrada
                return NotFound();
            }

            // Atualiza os campos da etapa existente
            etapaExistente.NomeEtapa = etapaDto.NomeEtapa;
            etapaExistente.Descricao = etapaDto.Descricao;
            etapaExistente.DataConclusao = etapaDto.DataConclusao;

            // Marca a etapa como modificada
            _context.Entry(etapaExistente).State = EntityState.Modified;

            // Salva as mudanças no banco de dados
            await _context.SaveChangesAsync();

            // Retorna status 204 sem conteúdo, indicando que a atualização foi bem-sucedida
            return NoContent();
        }

        // Obter uma etapa específica (detalhada)
        [HttpGet("{id}")]
        public async Task<ActionResult<EtapaDTO>> GetEtapa(int id)
        {
            // Encontra a etapa pelo ID
            var etapa = await _context.Etapas.FindAsync(id);

            // Se a etapa não for encontrada, retorna erro 404
            if (etapa == null)
            {
                return NotFound();
            }

            // Converte a etapa para DTO antes de retornar
            var etapaDto = new EtapaDTO
            {
                IdEtapa = etapa.IdEtapa,
                NomeEtapa = etapa.NomeEtapa,
                Descricao = etapa.Descricao,
                DataConclusao = etapa.DataConclusao,
                IdObra = etapa.IdObra
            };

            return etapaDto;
        }

        // Excluir uma etapa
        [HttpDelete("excluir/{id}")]
        public async Task<IActionResult> DeleteEtapa(int id)
        {
            // Encontra a etapa pelo ID
            var etapa = await _context.Etapas.FindAsync(id);

            if (etapa == null)
            {
                // Retorna erro 404 se a etapa não for encontrada
                return NotFound();
            }

            // Remove a etapa do banco de dados
            _context.Etapas.Remove(etapa);
            await _context.SaveChangesAsync();

            // Retorna status 204 (sem conteúdo) após a exclusão
            return NoContent();
        }
    }
}
