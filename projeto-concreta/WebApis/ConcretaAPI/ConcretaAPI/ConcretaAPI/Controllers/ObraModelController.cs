using ConcretaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ConcretaAPI.Data;
using ConcretaAPI.DTOs; // Para acessar o DbContext

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


        [HttpGet("{id}")]
        public async Task<ActionResult<ObraModel>> GetObra(int id)
        {
            var obra = await _context.Obras.FindAsync(id);
            if (obra == null) return NotFound();
            return obra;
        }
    }
}


