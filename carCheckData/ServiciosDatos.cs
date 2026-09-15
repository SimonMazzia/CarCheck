using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carCheckEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


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

        public bool Eliminar(int servicioId)
        {
            using (var db = new CarCheckDbContext())
            {
                var servicio = db.Servicios.FirstOrDefault(s => s.Id == servicioId);
                if (servicio == null)
                {
                    return false;
                }

                db.Servicios.Remove(servicio);
                db.SaveChanges();
                return true;

            }


        }
        public Servicio ObtenerPorId(int servicioId)
        {
            using(var db = new CarCheckDbContext())
            {
                return db.Servicios.FirstOrDefault(s => s.Id == servicioId);

            }
        }

        public bool Modificar(Servicio servicio)
        {
            using(var db= new CarCheckDbContext())
            {
                var servicioExistente = db.Servicios.FirstOrDefault(s => s.Id == servicio.Id);

                if(servicioExistente == null)
                {
                    return false;

                }

                servicioExistente.VehiculoId = servicio.VehiculoId;
                servicioExistente.TipoServicioId = servicio.TipoServicioId;
                servicioExistente.Fecha = servicio.Fecha;
                servicioExistente.Kilometraje = servicio.Kilometraje;
                servicioExistente.Costo = servicio.Costo;
                servicioExistente.Descripcion= servicio.Descripcion;
                db.SaveChanges();
                return true;
            }
        }
    }
}
