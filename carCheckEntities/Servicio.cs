namespace carCheckEntities
{
    public class Servicio
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }   // 🔗 FK
        public DateTime Fecha { get; set; }
        public string TipoServicio { get; set; }
        public int KilometrajeCambio { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }

        // 🔗 Propiedad de navegación
        public Vehiculo Vehiculo { get; set; }
    }
}
