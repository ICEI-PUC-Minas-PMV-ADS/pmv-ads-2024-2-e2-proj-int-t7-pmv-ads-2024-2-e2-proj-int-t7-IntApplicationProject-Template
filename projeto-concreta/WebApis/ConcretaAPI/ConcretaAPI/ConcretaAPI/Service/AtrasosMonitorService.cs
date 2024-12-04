namespace ConcretaAPI.Service
{
    using ConcretaAPI.Data;
    using ConcretaAPI.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Net;
    using System.Net.Mail;

    public class AtrasosMonitorService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public AtrasosMonitorService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    var hoje = DateTime.UtcNow;

                    var etapasAtrasadas = await context.Etapas
                        .Include(e => e.Obra)
                        .Where(e => !e.Obra.EstaConcluido &&
                                    e.DataConclusao.HasValue &&
                                    e.DataConclusao.Value < hoje)
                        .ToListAsync();

                    foreach (var etapa in etapasAtrasadas)
                    {
                        var usuario = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == etapa.Obra.IdUsuario);

                        if (usuario != null)
                        {
                            await EnviarEmail(usuario.Email, "Atraso na Etapa",
                                $"A etapa '{etapa.NomeEtapa}' da obra '{etapa.Obra.Nome}' está atrasada.");
                        }
                    }

                    var obrasAtrasadas = await context.Obras
                        .Where(o => !o.EstaConcluido && o.DataFim.HasValue && o.DataFim.Value < hoje)
                        .ToListAsync();

                    foreach (var obra in obrasAtrasadas)
                    {
                        var usuario = await context.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == obra.IdUsuario);

                        if (usuario != null)
                        {
                            await EnviarEmail(usuario.Email, "Atraso na Obra",
                                $"A obra '{obra.Nome}' localizada em '{obra.Localizacao}' está atrasada. O prazo final era {obra.DataFim.Value:dd/MM/yyyy}.");
                        }
                    }
                }
                await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
            }
        }

        private async Task EnviarEmail(string emailDestinatario, string assunto, string mensagemBody)
        {
            var mensagem = new MailMessage
            {
                From = new MailAddress("concretapuc@gmail.com"),
                Subject = assunto,
                Body = mensagemBody,
                IsBodyHtml = true
            };
            mensagem.To.Add(emailDestinatario);

            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("concretapuc@gmail.com", "dveq ymxu lzqj naib");
                await smtp.SendMailAsync(mensagem);
            }
        }
    }
}
