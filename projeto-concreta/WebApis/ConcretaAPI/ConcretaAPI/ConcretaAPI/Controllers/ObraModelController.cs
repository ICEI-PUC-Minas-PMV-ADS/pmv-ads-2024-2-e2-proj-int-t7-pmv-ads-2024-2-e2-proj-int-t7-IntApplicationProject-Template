using ConcretaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ConcretaAPI.Data;
using ConcretaAPI.DTOs;
using Microsoft.EntityFrameworkCore; // Para acessar o DbContext


namespace ConcretaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObraModelController : ControllerBase
    {
        private readonly AppDbContext _context;

        private static int? CurrentUserId;


        public ObraModelController(AppDbContext context)
        {
            _context = context;
        }

            //Método para adicionar uma nova Obra com mapeamento entre DTO e entidade
            [HttpPost("cadastrar")]
            public async Task<ActionResult<ObraDTO>> PostObras(ObraDTO obraDto, int userId)
            {
                // Cria a nova obra e associa o IdUsuario à obra

                var obra = new ObraModel

                {
                    Nome = obraDto.Nome,
                    Construtora = obraDto.Construtora, // Adicionando o campo Construtora
                    Localizacao = obraDto.Localizacao,
                    Descricao = obraDto.Descricao,
                    DataInicio = obraDto.DataInicio,
                    DataFim = obraDto.DataFim,
                    IdUf = obraDto.IdUf,
                    EstaConcluido = obraDto.EstaConcluido,
                    IdUsuario = obraDto.IdUsuario, // Associa a obra ao ID do usuário logado
                };

                _context.Obras.Add(obra);
                await _context.SaveChangesAsync();

                obraDto.IdObra = obra.IdObra;

                return Ok(new { mensagem = "obra cadastrada com sucesso!", id = obraDto.IdObra, obraDto });

            }

            [HttpGet("em-andamento")]
            public async Task<ActionResult<IEnumerable<ObraModel>>> GetObrasEmAndamento()
            {
                var obrasEmAndamento = await _context.Obras
                    .ToListAsync();
                return obrasEmAndamento;
            }

            [HttpGet("obra-finalizada")]
            public async Task<ActionResult<IEnumerable<ObraModel>>> GetObraFinalizada()
            {
                var obraFinalizada = await _context.Obras
                    .ToListAsync();
                return obraFinalizada;
            }

            [HttpGet("obra-escolhida/{id}")]
            public async Task<ActionResult<ObraModel>> GetObraById(int id)
            {
                // Busca a obra pelo ID
                var obra = await _context.Obras.FindAsync(id);

                // Verifica se a obra foi encontrada
                if (obra == null)
                {
                    return NotFound(new { message = "Obra não encontrada." });
                }

                return Ok(obra);
            }

            [HttpPut("obra-escolhida/{id}")]
            public async Task<ActionResult<ObraModel>> AtualizarCampoEstaConcluido(int id, [FromBody] AtualizarObraRequest request)
            {
                var obra = await _context.Obras.FindAsync(id);

                if (obra == null)
                {
                    return NotFound(new { message = "Obra não encontrada." });
                }

                // Atualizando apenas o campo "estaConcluido"
                obra.EstaConcluido = request.EstaConcluido;

                _context.Obras.Update(obra);
                await _context.SaveChangesAsync();

                return Ok(obra);
            }

            [HttpGet("obras")]
            public async Task<ActionResult<IEnumerable<ObraModel>>> GetObrasPorUsuario([FromQuery] int idUsuario)
            {
                // Tenta buscar as obras associadas ao usuário logado
                var obras = await _context.Obras.Where(o => o.IdUsuario == idUsuario).ToListAsync();

                // Se não houver obras para o usuário, retorna uma mensagem informando que não há obras
                if (obras == null || !obras.Any())
                {
                    // Retorna uma resposta Ok com a mensagem
                    return Ok(new { message = "Nenhuma obra encontrada para o usuário." });
                }

                // Caso contrário, retorna as obras
                return Ok(obras);
            }

            // Excluir uma obra
            [HttpDelete("excluir/{id}")]
            public async Task<IActionResult> DeleteObraById(int id)
            {
                var obras = await _context.Obras.FindAsync(id);
                if (obras == null)
                {
                    // Retorna erro 404 se a obra não for encontrada
                    return NotFound();
                }

                // Remove a obra do banco de dados
                _context.Obras.Remove(obras);
                await _context.SaveChangesAsync();

                // Retorna status 204 (sem conteúdo) após a exclusão
                return NoContent();
            }

        }

    }

 



