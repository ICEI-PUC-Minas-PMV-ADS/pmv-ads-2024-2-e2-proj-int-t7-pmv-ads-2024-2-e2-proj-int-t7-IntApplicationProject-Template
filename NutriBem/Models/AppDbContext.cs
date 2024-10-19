using Microsoft.EntityFrameworkCore;

namespace NutriBem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Receita> Receitas { get; set; }
     
    }
}
