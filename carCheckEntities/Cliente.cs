using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carCheckEntities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
    public class Vehiculo 
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Patente { get; set; }

        public int Kilometraje { get; set; }
        public int ClienteId { get; set; }
    }

    public class Servicio 
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoServicio { get; set; }
        public int KilometrajeCambio { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }

    }
}
