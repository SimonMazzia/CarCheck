using carCheckEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carCheckData
{
    public class VehiculoDatos
    {
        public void Registrar(Vehiculo vehiculo)
        {
            using (var db = new CarCheckDbContext())
            {
                db.Vehiculos.Add(vehiculo);
                db.SaveChanges();
            }
        }
        public List<Vehiculo> ObtenerVehiculosPorUsuario(int usuarioID)
        {
            using (var db = new CarCheckDbContext())
            {
                return db.Vehiculos.Where(v => v.UsuarioId == usuarioID).ToList();
            }


        }
        public bool existePatente(string patente)
        {
            using (var db= new CarCheckDbContext())
            {
                return db.Vehiculos.Any(v => v.Patente == patente);
            }
        }
        public bool eliminarVehiculo(int Id)
        {
            using (var db = new CarCheckDbContext())
            {
                Vehiculo? vehiculo = db.Vehiculos.FirstOrDefault(v => v.Id == Id);
                if (vehiculo == null)
                {
                    return false;
                }
                db.Vehiculos.Remove(vehiculo);
                db.SaveChanges();
                return true;
            }
        }
        public bool ModificarVehiculo(Vehiculo vehiculoModificado)
        {
            using (var db = new CarCheckDbContext())
            {
                Vehiculo? vehiculo = db.Vehiculos.FirstOrDefault(v => v.Id == vehiculoModificado.Id);
                if (vehiculo == null)
                {
                    return false;
                }
                vehiculo.Marca = vehiculoModificado.Marca;
                vehiculo.Modelo = vehiculoModificado.Modelo;
                vehiculo.Anio = vehiculoModificado.Anio;
                vehiculo.Patente = vehiculoModificado.Patente;
                vehiculo.Kilometraje = vehiculoModificado.Kilometraje;
                db.SaveChanges();
                return true;
            }
        }
    }
}
