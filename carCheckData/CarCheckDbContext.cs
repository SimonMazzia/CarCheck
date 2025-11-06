using Microsoft.EntityFrameworkCore;
using carCheckEntities;

namespace carCheckData
{
    public class CarCheckDbContext : DbContext
    {
        public DbSet<Usuario> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SIMON_PC\\SQLEXPRESS;Database=CarCheckDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
