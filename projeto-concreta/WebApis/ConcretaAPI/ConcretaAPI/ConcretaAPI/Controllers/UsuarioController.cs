using ConcretaAPI.Data;
using ConcretaAPI.DTOs;
using ConcretaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConcretaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public class CadastrarUsuarioDto
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public string ConfirmarSenha { get; set; }
            public int IdTipoUsuario { get; set; }
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] CadastrarUsuarioDto usuarioDto)
        {
            if (string.IsNullOrWhiteSpace(usuarioDto.Nome) ||
                string.IsNullOrWhiteSpace(usuarioDto.Email) ||
                string.IsNullOrWhiteSpace(usuarioDto.Senha) ||
                string.IsNullOrWhiteSpace(usuarioDto.ConfirmarSenha))
            {
                return BadRequest(new { mensagem = "Todos os campos são obrigatórios." });
            }

            if (usuarioDto.Senha != usuarioDto.ConfirmarSenha)
            {
                return BadRequest(new { mensagem = "A senha e a confirmação da senha devem coincidir." });
            }

            var usuarioExistente = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == usuarioDto.Email);

            if (usuarioExistente != null)
            {
                return BadRequest(new { mensagem = "O e-mail informado já está cadastrado." });
            }

            Usuario usuario = new Usuario
            {
                Nome = usuarioDto.Nome,
                Email = usuarioDto.Email,
                Senha = usuarioDto.Senha,
                IdTipoUsuario = usuarioDto.IdTipoUsuario,
                DescricaoTipoUsuario = usuarioDto.IdTipoUsuario == 1 ? "Gestor" : "Cliente"
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Usuário cadastrado com sucesso!" });
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
        {
            if (string.IsNullOrWhiteSpace(loginDto.Email) || string.IsNullOrWhiteSpace(loginDto.Senha))
            {
                return BadRequest(new { mensagem = "Email e senha são obrigatórios." });
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == loginDto.Email);

            if (usuario == null)
            {
                return NotFound(new { mensagem = "Email não cadastrado." });
            }

            if (usuario.Senha != loginDto.Senha)
            {
                return Unauthorized(new { mensagem = "Senha incorreta." });
            }

            return Ok(new { mensagem = "Login realizado com sucesso!", idTipoUsuario = usuario.IdTipoUsuario });
        }

        [HttpPost("solicitar-redefinicao-senha")]
        public async Task<IActionResult> SolicitarRedefinicaoSenha([FromBody] SolicitarRedefinicaoSenhaDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Email))
            {
                return BadRequest(new { message = "O campo email é obrigatório." });
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if (usuario == null)
            {
                return NotFound(new { message = "Usuário não encontrado." });
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sua-chave-secreta-super-segura-de-32-caracteres"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new System.Security.Claims.Claim(JwtRegisteredClaimNames.Sub, usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);


            var link = $"http://localhost:4200/redefinir-senha?token={tokenString}";

            var body = $@"
            <html>
            <head>
                <style>
                    body {{ font-family: Arial, sans-serif; background-color: #f4f4f4; color: #333; }}
                    .container {{ background-color: #fff; padding: 20px; border-radius: 8px; }}
                    .link {{ color: #4CAF50; font-weight: bold; }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <h2>Redefinição de Senha</h2>
                    <p>Clique no link abaixo para redefinir sua senha:</p>
                    <a class='link' href='{link}'>Redefinir Senha</a>
                    <p>Este link expira em 1 hora.</p>
                </div>
            </body>
            </html>";

            var mensagem = new MailMessage
            {
                From = new MailAddress("concretapuc@gmail.com"),
                Subject = "Redefinição de Senha",
                Body = body,
                IsBodyHtml = true
            };
            mensagem.To.Add(usuario.Email);

            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("concretapuc@gmail.com", "dveq ymxu lzqj naib");
                await smtp.SendMailAsync(mensagem);
            }

            return Ok(new { message = "Email de redefinição enviado com sucesso!" });
        }


        [HttpPost("confirmar-redefinicao-senha")]
        public async Task<IActionResult> ConfirmarRedefinicaoSenha([FromBody] RedefinirSenhaDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Token) ||
                string.IsNullOrWhiteSpace(dto.NovaSenha) ||
                string.IsNullOrWhiteSpace(dto.ConfirmarSenha))
            {
                return BadRequest(new { mensagem = "Todos os campos são obrigatórios." });
            }

            if (dto.NovaSenha != dto.ConfirmarSenha)
            {
                return BadRequest(new { mensagem = "A nova senha e a confirmação devem coincidir." });
            }

            var handler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sua-chave-secreta-super-segura-de-32-caracteres"));
            var creds = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ValidateLifetime = true,
                ValidateAudience = false,
                ValidateIssuer = false
            };

            try
            {
                handler.ValidateToken(dto.Token, creds, out validatedToken);
            }
            catch
            {
                return Unauthorized(new { mensagem = "Token inválido ou expirado." });
            }

            var jwtToken = validatedToken as JwtSecurityToken;
            var email = jwtToken?.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value;

            if (email == null)
            {
                return Unauthorized(new { mensagem = "Token inválido." });
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
            if (usuario == null)
            {
                return NotFound(new { mensagem = "Usuário não encontrado." });
            }


            usuario.Senha = dto.NovaSenha;
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Senha redefinida com sucesso!" });
        }
    }

}

