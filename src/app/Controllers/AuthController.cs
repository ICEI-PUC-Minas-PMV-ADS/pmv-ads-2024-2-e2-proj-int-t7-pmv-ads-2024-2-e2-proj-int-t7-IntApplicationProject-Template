using app.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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

        return RedirectToAction("Index", "Usinas");  // Alterado de "Home" para "Usinas"
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }
}
