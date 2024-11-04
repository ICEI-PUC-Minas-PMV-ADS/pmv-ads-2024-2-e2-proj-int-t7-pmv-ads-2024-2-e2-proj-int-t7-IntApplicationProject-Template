using ConcretaAPI.Data;
using ConcretaAPI.DTOs;
using ConcretaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    }
}
