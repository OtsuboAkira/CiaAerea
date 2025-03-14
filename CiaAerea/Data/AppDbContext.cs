using CiaAerea.Models;
using Microsoft.EntityFrameworkCore;

namespace CiaAerea.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Voo> Voos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

    }
}
