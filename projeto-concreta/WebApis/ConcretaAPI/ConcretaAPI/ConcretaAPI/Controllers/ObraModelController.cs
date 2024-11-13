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

        public ObraModelController(AppDbContext context)
        {
            _context = context;
        }
        //Método para adicionar uma nova Obra com mapeamento entre DTO e entidade
        [HttpPost("cadastrar")]
        public async Task<ActionResult<ObraDTO>> PostObras(ObraDTO obraDto)
        {
            var obra = new ObraModel
            {
                Nome = obraDto.Nome,
                Localizacao = obraDto.Localizacao,
                Descricao = obraDto.Descricao,
                DataInicio = obraDto.DataInicio,
                DataFim = obraDto.DataFim,
                IdUf = obraDto.IdUf,
                IdArquivoFoto = obraDto.IdArquivoFoto,
            };

            _context.Obras.Add(obra);
            await _context.SaveChangesAsync();

            obraDto.IdObra = obra.IdObra;

            return CreatedAtAction("GetObra", new { id = obraDto.IdObra }, obraDto);
        }

        [HttpGet("em-andamento")]
        public async Task<ActionResult<IEnumerable<ObraModel>>> GetObrasEmAndamento()
        {
            var obrasEmAndamento = await _context.Obras
                .Where(obra => obra.DataFim == null || obra.DataFim > DateTime.Now)
                .ToListAsync();
            return obrasEmAndamento;
        }

        [HttpGet("obras-finalizadas")]
        public async Task<ActionResult<IEnumerable<ObraModel>>> GetObrasFinalizadas()
        {
            var obrasFinalizadas = await _context.Obras
                .Where(obra => obra.DataFim != null && obra.DataFim <= DateTime.Now)
                .ToListAsync();

            return obrasFinalizadas;
        }

    }
}



