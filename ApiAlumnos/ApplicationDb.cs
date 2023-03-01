using ApiFacturador.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Identity.Client;

namespace ApiFacturador 
{ 



    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Factura> Faturas { get; set; }

        public DbSet<Motocicleta> motocicleta { get; set; }

        public DbSet<Motor> Motor { get; set; }

        public DbSet<Llanta> Llanta { get; set; }
    }
}
