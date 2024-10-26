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

            string body = $@"
<html>
<head>
    <style>
        body {{
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            color: #333;
            padding: 20px;
        }}
        .container {{
            background-color: #fff;
            border-radius: 8px;
            padding: 20px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }}
        h2 {{
            color: #4CAF50;
        }}
        .info {{
            margin: 10px 0;
        }}
        .label {{
            font-weight: bold;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <h2>Mensagem de Contato</h2>
        <div class='info'>
            <span class='label'>Nome:</span> {contato.Nome}
        </div>
        <div class='info'>
            <span class='label'>Email:</span> {contato.Email}
        </div>
        <div class='info'>
            <span class='label'>Mensagem:</span>
            <p>{contato.Mensagem}</p>
        </div>
    </div>
</body>
</html>";


            // Enviar email
            var mensagem = new MailMessage
            {
                From = new MailAddress("concretapuc@gmail.com"), // Coloque seu email aqui
                Subject = "Nova Mensagem de Contato",
                Body = $"Nome: {contato.Nome} Email: {contato.Email} Mensagem: {contato.Mensagem}",
                IsBodyHtml = false
            };
            mensagem.To.Add("concretapuc@gmail.com");

            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("concretapuc@gmail.com", "dveq ymxu lzqj naib"); // Coloque seu email e senha
                await smtp.SendMailAsync(mensagem);
            }

            return Ok("Mensagem enviada com sucesso!");
        }
    }
}