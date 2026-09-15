using carCheckEntities;
using System.Collections.Generic;
using System.Linq;

namespace carCheckData
{
    public class TipoServicioDatos
    {
        public List<TipoServicio> ObtenerTodos()
        {
            using (var db = new CarCheckDbContext())
            {
                return db.TiposServicio
                    .OrderBy(t => t.Nombre)
                    .ToList();
            }
        }
    }
}