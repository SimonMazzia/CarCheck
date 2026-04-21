using System.ComponentModel.DataAnnotations;

namespace carCheckEntities;

public class Usuario
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string NombreUsuario { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    // Relación uno a muchos
    public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    public string? TokenRecuperacion { get; set; } 

}