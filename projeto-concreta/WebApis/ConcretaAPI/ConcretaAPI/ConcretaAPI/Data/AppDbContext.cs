using ConcretaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ConcretaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Definir DbSet para as suas entidades
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<ObraModel> Obras { get; set; }

        // Configurações adicionais do modelo (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Adicione aqui configurações específicas, como chaves compostas, etc.
        }
    }

}
