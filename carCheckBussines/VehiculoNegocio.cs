using carCheckData;
using carCheckEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carCheckBussines
{
    public class VehiculoNegocio
    {
        private readonly VehiculoDatos vehiculoDatos = new VehiculoDatos();
        public bool RegistrarVehiculo(Vehiculo vehiculo, out string mensaje)
        {
            
            mensaje = string.Empty;
            //validaciones
            if (vehiculoDatos.existePatente(vehiculo.Patente))
            {
                mensaje = "La patente ya existe. Por favor, ingrese una patente única.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(vehiculo.Marca) || string.IsNullOrWhiteSpace(vehiculo.Modelo) || string.IsNullOrWhiteSpace(vehiculo.Patente))
            {
                mensaje = "Marca, Modelo y Patente son campos obligatorios.";
                return false;
            }
            vehiculoDatos.Registrar(vehiculo);
            mensaje = "Vehículo registrado exitosamente.";
            return true;
        }
        public List<Vehiculo> ObtenerVehiculosPorUsuario(int usuarioId) => vehiculoDatos.ObtenerVehiculosPorUsuario(usuarioId);
        public bool EliminarVehiculo(
            int id,
            out string mensaje)
        {
            mensaje = string.Empty;

            bool eliminado =
                vehiculoDatos.eliminarVehiculo(id);

            if (!eliminado)
            {
                mensaje = "No se pudo eliminar el vehículo.";
                return false;
            }

            mensaje = "Vehículo eliminado correctamente.";

            return true;
        }
        public bool ModificarVehiculo(
            Vehiculo vehiculo,
            out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
            {
                mensaje = "La marca es obligatoria.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
            {
                mensaje = "El modelo es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehiculo.Patente))
            {
                mensaje = "La patente es obligatoria.";
                return false;
            }

            bool modificado =
                vehiculoDatos.ModificarVehiculo(vehiculo);

            if (!modificado)
            {
                mensaje = "No se pudo modificar el vehículo.";
                return false;
            }

            mensaje = "Vehículo modificado correctamente.";

            return true;
        }
    }
}
