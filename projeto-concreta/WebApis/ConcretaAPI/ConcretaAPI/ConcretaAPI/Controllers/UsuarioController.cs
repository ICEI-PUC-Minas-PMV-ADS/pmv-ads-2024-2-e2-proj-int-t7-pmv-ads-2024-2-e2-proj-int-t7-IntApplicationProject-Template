using ConcretaAPI.Data;
using ConcretaAPI.Models;
using Microsoft.AspNetCore.Mvc;
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
            // Valida os campos obrigatórios
            if (string.IsNullOrWhiteSpace(usuarioDto.Nome) ||
                string.IsNullOrWhiteSpace(usuarioDto.Email) ||
                string.IsNullOrWhiteSpace(usuarioDto.Senha) ||
                string.IsNullOrWhiteSpace(usuarioDto.ConfirmarSenha))
            {
                return BadRequest(new { mensagem = "Todos os campos são obrigatórios." });
            }

            // Verifica se a senha e a confirmação são iguais
            if (usuarioDto.Senha != usuarioDto.ConfirmarSenha)
            {
                return BadRequest(new { mensagem = "A senha e a confirmação da senha devem coincidir." });
            }

            // Cria um novo usuário
            Usuario usuario = new Usuario
            {
                Nome = usuarioDto.Nome,
                Email = usuarioDto.Email,
                Senha = usuarioDto.Senha, // Considere usar hashing aqui
                IdTipoUsuario = usuarioDto.IdTipoUsuario,
                DescricaoTipoUsuario = usuarioDto.IdTipoUsuario == 1 ? "Gestor" : "Cliente"
            };

            // Adiciona o usuário ao contexto e salva as mudanças
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(new { mensagem = "Usuário cadastrado com sucesso!" });
        }
    }
}