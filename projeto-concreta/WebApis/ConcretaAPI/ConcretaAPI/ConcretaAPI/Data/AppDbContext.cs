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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EtapaModel> Etapas { get; set; }

        // Configurações adicionais do modelo (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração EtapaModel e ObraModel
            modelBuilder.Entity<EtapaModel>()
                .HasOne(e => e.Obra)  // Etapa tem uma Obra
                .WithMany(o => o.Etapas)  // Obra pode ter várias Etapas
                .HasForeignKey(e => e.IdObra);  // Chave estrangeira na EtapaModel
        }
    }

}
