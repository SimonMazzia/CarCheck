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
        public List<Servicio> ObtenerServiciosPorUsuario(int usuarioId)
            {
            return servicioDatos.ObtenerServiciosPorUsuario(usuarioId);
        }

        public bool EliminarServicio(int servicioId, out string mensaje)
        {
            mensaje = string.Empty;
            if (servicioId <= 0)
            {
                mensaje = "Debe seleccionar un servicio valido";
                return false;
            }
            bool eliminado = servicioDatos.Eliminar(servicioId);
            if (!eliminado)
            {
                mensaje = "No se pudo eliminar el servicio. Verifique que exista.";
                return false;
            }
            mensaje = "Servicio eliminado exitosamente.";
            return true;
        }

        public Servicio ObtenerPorId(int servicioId)
        {
            return servicioDatos.ObtenerPorId(servicioId);

        }

        public bool ModificarServicio(Servicio servicio, out string mensaje)
        {
            mensaje= string.Empty;

            if (servicio.Id <= 0)
            {
                mensaje = "El servicio seleccionado no es valido";

                return false;
            }

            if (servicio.VehiculoId <= 0)
            {
                mensaje= "Debe seleccionar un vehiculo";
                return false;

            }

            if (servicio.TipoServicioId <= 0)
            {
                mensaje = "Debe seleccionar un servicio";
                return false;

            }
            if(servicio.Fecha == default)
            {
                mensaje = "Debe seleccionar una fecha valida";
                return false;

            }
            if (servicio.Kilometraje < 0)
            {
                mensaje = "Debe seleccionar un kilometraje valido";
                return false;
                
            }
            if(servicio.Costo < 0)
            {
                mensaje = "Debe seleccionar un costo valido ";
                return false;

            }

            bool modificado = servicioDatos.Modificar(servicio);

            if (!modificado)
            {
                mensaje = "No se encontró el servicio.";
                return false;
            }

            mensaje = "Servicio modificado correctamente.";
            return true;
        }
    }
}
