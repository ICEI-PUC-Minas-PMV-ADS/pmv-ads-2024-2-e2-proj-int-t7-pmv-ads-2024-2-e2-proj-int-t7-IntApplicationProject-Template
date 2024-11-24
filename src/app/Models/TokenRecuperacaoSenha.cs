using app.Models;

public class TokenRecuperacaoSenha
{
    public int Id { get; set; }
    public Guid UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public string Token { get; set; }
    public DateTime DataExpiracao { get; set; }
}
