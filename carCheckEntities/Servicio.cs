namespace carCheckEntities;
public class Servicio
{
    public int Id { get; set; }
    public int VehiculoId { get; set; }
    public Vehiculo Vehiculo { get; set; }

    public DateTime Fecha { get; set; }
    public string TipoServicio { get; set; }
    public int KilometrajeCambio { get; set; }
    public string Descripcion { get; set; }
    public decimal Costo { get; set; }
}