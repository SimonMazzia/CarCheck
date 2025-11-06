namespace carCheckEntities;

public class Vehiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public string Patente { get; set; }
    public int Kilometraje { get; set; }

    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public ICollection<Servicio> Servicios { get; set; }
}