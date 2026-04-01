using System.ComponentModel.DataAnnotations;

namespace carCheckEntities;

public class Vehiculo
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Marca { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Modelo { get; set; } = string.Empty;

    public int Anio { get; set; }

    [Required]
    [MaxLength(20)]
    public string Patente { get; set; } = string.Empty;

    public int Kilometraje { get; set; }

    [Required]
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}