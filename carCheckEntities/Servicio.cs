using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carCheckEntities;

public class Servicio
{
    public int Id { get; set; }

    public int VehiculoId { get; set; }
    public Vehiculo Vehiculo { get; set; }

    public DateTime Fecha { get; set; }

    public TipoServicio TipoServicio { get; set; }

    public int Kilometraje { get; set; }

    [MaxLength(255)]
    public string Descripcion { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10,2)")]
    public decimal Costo { get; set; }
}

public enum TipoServicio
{
    Preventivo,
    Correctivo
}