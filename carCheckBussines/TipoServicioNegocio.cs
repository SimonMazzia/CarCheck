using carCheckData;
using carCheckEntities;
using System.Collections.Generic;

namespace carCheckBussines
{
    public class TipoServicioNegocio
    {
        private readonly TipoServicioDatos tipoServicioDatos =
            new TipoServicioDatos();

        public List<TipoServicio> ObtenerTodos()
        {
            return tipoServicioDatos.ObtenerTodos();
        }
    }
}