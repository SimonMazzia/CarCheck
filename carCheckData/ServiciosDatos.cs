using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carCheckEntities;
using Microsoft.EntityFrameworkCore;


namespace carCheckData
{
    public class ServiciosDatos
    {
        public void Registrar(Servicio servicio)
        {
            using (var db = new CarCheckDbContext())
            {
                db.Servicios.Add(servicio);
                db.SaveChanges();
            }
        }

        public List<Servicio> ObtenerServiciosPorUsuario(int usuarioId)
        {
            using (var db = new CarCheckDbContext())
            {
                return db.Servicios
                    .Include(s => s.Vehiculo)
                    .Include(s => s.TipoServicio)
                    .Where(s => s.Vehiculo.UsuarioId == usuarioId)
                    .OrderByDescending(s => s.Fecha)
                    .ToList();
            }
        }
    }
}
