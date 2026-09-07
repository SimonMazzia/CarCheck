using carCheckData;
using carCheckEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carCheckBussines
{
    public class ServicioNegocio
    {
        private readonly ServiciosDatos servicioDatos = new ServiciosDatos();
        public bool RegistrarServicio(Servicio servicio, out string mensaje)
        {
            mensaje = string.Empty;
            //validaciones
            if (servicio.VehiculoId <= 0)
            {
                mensaje = "Debe seleccionar un vehiculo valido";
                return false;

            }

            if (servicio.TipoServicioId <= 0)
            {
                mensaje = "Debe seleccionar un tipo de servicio valido";
                return false;
            }
            if (servicio.Fecha == default)
            {
                mensaje = "Debe seleccionar una fecha valida";
                return false;
            }
            if (servicio.Kilometraje < 0)
            {
                mensaje = "Debe ingresar un kilometraje valido";
                return false;
            }
            if (servicio.Costo < 0)
            {
                mensaje = "Debe ingresar un costo valido";
                return false;
            }
            servicioDatos.Registrar(servicio);
            mensaje = "Servicio registrado exitosamente.";
            return true;

        }
    }
}
