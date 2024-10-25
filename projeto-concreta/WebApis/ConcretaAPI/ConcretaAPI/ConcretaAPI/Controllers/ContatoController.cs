using ConcretaAPI.Data; // Para acessar o DbContext

using ConcretaAPI.Models; 

using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ConcretaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContatoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> EnviarMensagem([FromBody] Contato contato)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Salvar no banco de dados
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();

            // Enviar email
            var mensagem = new MailMessage
            {
                From = new MailAddress("seu_email@gmail.com"), // Coloque seu email aqui
                Subject = "Nova Mensagem de Contato",
                Body = $"Nome: {contato.Nome}\nEmail: {contato.Email}\nMensagem: {contato.Mensagem}",
                IsBodyHtml = false
            };
            mensagem.To.Add("concretapuc@gmail.com");

            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("seu_email@gmail.com", "sua_senha"); // Coloque seu email e senha
                await smtp.SendMailAsync(mensagem);
            }

            return Ok("Mensagem enviada com sucesso!");
        }
    }
}