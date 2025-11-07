namespace carCheckEntities;

public class Usuario
{
    public int Id { get; set; }
    public string NombreUsuario { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    // Relación uno a muchos
    public ICollection<Vehiculo> Vehiculos { get; set; }
}