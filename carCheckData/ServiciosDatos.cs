using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carCheckEntities;


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
    }
}
