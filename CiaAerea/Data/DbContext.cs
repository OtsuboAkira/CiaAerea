using CiaAerea.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CiaAerea.Data
{
    public class DbContext : ControllerBase
    {
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Voo> Voos { get; set; }
        public DbContext() { }

    }
}
