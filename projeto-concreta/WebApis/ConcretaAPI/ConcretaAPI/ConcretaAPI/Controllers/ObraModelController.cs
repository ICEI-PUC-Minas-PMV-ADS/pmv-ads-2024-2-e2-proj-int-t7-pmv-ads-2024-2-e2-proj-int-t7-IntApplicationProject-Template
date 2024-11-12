using ConcretaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ConcretaAPI.Data; // Para acessar o DbContext

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
        [HttpPost]
        public async Task<ActionResult<ObraModel>> PostObras(ObraModel obra)
        {
            _context.Obras.Add(obra);
            await _context.SaveChangesAsync();  // Salva as mudanças no banco, incluindo a geração do IdObra

            // Retorna a obra criada, incluindo o IdObra e demais informações salvas
            return CreatedAtAction("GetObra", new { id = obra.IdObra }, obra);
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


