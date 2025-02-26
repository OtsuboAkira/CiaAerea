using Microsoft.AspNetCore.Mvc;

namespace CiaAerea.Data
{
    public class DbContext : ControllerBase
    {
        public DbSet<> Myproperty { get; set; }
        public DbContext() { }
    }
}
