using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carCheckEntities
{
    public class Estado
    {
        public int Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        
        public ICollection<Servicio> servicios { get; set; } = new List<Servicio>();
    }
}
