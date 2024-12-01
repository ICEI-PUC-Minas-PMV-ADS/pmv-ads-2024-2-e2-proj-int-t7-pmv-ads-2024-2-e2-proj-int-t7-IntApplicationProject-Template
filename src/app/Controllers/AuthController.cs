using app.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Security.Claims;
using app.Models;
using app.Models.ViewModels;
using System.Security.Cryptography;

public class AuthController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public AuthController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult Login()
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction("Index", "Home");

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var usuario = await _dbContext.Usuarios
            .Include(u => u.GruposPermissoes)
                .ThenInclude(gp => gp.Permissoes)
            .FirstOrDefaultAsync(u => u.Email == model.Email);

        if (usuario == null || usuario.Password != model.Password) // Em produção, use hash!
        {
            ModelState.AddModelError("", "Credenciais inválidas");
            return View(model);
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, usuario.Nome),
            new Claim(ClaimTypes.Email, usuario.Email),
            new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString())
        };

        // Adiciona todas as permissões únicas do usuário
        var permissoes = usuario.GruposPermissoes
            .SelectMany(gp => gp.Permissoes)
            .Select(p => p.Nome)
            .Distinct();

        foreach (var permissao in permissoes)
        {
            claims.Add(new Claim("Permissoes", permissao));
        }

        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            principal,
            new AuthenticationProperties
            {
                IsPersistent = model.RememberMe
            });

        return RedirectToAction("Index", "Usinas"); // Alterado de "Home" para "Usinas"
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }

    // Método para exibir a página de recuperação de senha
    [HttpGet]
    public IActionResult RecuperarSenha()
    {
        return View();
    }

    // Método para processar o pedido de recuperação de senha
    [HttpPost]
    public async Task<IActionResult> RecuperarSenha(string email)
    {
        var usuario = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
        if (usuario == null)
        {
            TempData["SuccessMessage"] = "Se o e-mail existir, você receberá instruções para redefinir a senha.";
            return RedirectToAction("RecuperarSenha");
        }

        // Gera um token para recuperação de senha
        var token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        var expiracao = DateTime.UtcNow.AddHours(1);

        // Salva o token no banco de dados
        var tokenRecuperacao = new TokenRecuperacaoSenha
        {
            UsuarioId = usuario.Id,
            Token = token,
            DataExpiracao = expiracao
        };

        _dbContext.TokensRecuperacaoSenha.Add(tokenRecuperacao);
        await _dbContext.SaveChangesAsync();

        // Gera o link de recuperação
        var resetLink = Url.Action(
            "RedefinirSenha",
            "Auth",
            new { token },
            Request.Scheme);

        // Envia o e-mail
        await EnviarEmailAsync(usuario.Email, "Recuperação de Senha", $"Clique no link para redefinir sua senha: {resetLink}");

        TempData["SuccessMessage"] = "Se o e-mail existir, você receberá instruções para redefinir a senha.";
        return RedirectToAction("RecuperarSenha");
    }

    // Método para exibir a página de redefinição de senha
    [HttpGet]
    public IActionResult RedefinirSenha(string token)
    {
        var model = new RedefinirSenhaViewModel { Token = token };
        return View(model);
    }

    // Método para processar a redefinição de senha
    [HttpPost]
    public async Task<IActionResult> RedefinirSenha(RedefinirSenhaViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var token = await _dbContext.TokensRecuperacaoSenha
            .Include(t => t.Usuario)
            .FirstOrDefaultAsync(t => t.Token == model.Token && t.DataExpiracao > DateTime.UtcNow);

        if (token == null)
        {
            ModelState.AddModelError("", "Token inválido ou expirado.");
            return View(model);
        }

        // Atualiza a senha do usuário (hash em produção)
        token.Usuario.Password = model.NovaSenha;
        _dbContext.TokensRecuperacaoSenha.Remove(token); // Remove o token após o uso
        await _dbContext.SaveChangesAsync();

        TempData["SuccessMessage"] = "Senha redefinida com sucesso. Faça login.";
        return RedirectToAction("Login");
    }

    private async Task EnviarEmailAsync(string email, string assunto, string mensagem)
    {
        // Implementar envio de e-mail
        // Placeholder (?)
        Console.WriteLine($"Email enviado para {email}: {mensagem}");
        await Task.CompletedTask;
    }
}