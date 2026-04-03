using Microsoft.EntityFrameworkCore;
using carCheckEntities;
using System.Linq;

namespace carCheckData
{
    public class CarCheckDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoServicio> TiposServicio { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SIMON_PC\\SQLEXPRESS;Database=CarCheckDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
