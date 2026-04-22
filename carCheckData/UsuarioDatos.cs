using carCheckEntities;
using System.Linq;

namespace carCheckData
{
    public class UsuarioDatos
    {
        public void Registrar(Usuario usuario)
        {
            using (var db = new CarCheckDbContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

        public Usuario Login(string email, string passwordHasheada)
        {
            using (var db = new CarCheckDbContext())
            {
                return db.Usuarios.FirstOrDefault(u => u.Email == email && u.PasswordHash == passwordHasheada);
            }
        }

        public bool ExisteEmail(string email)
        {
            using (var db = new CarCheckDbContext())
            {
                return db.Usuarios.Any(u => u.Email == email);
            }
        }

        public bool ActualizarPassword(string email, string nuevaPasswordHasheada)
        {
            using (var db = new CarCheckDbContext())
            {
                Usuario? usuario = db.Usuarios.FirstOrDefault(u => u.Email == email);
                if (usuario == null)
                {
                    return false;
                }

                usuario.PasswordHash = nuevaPasswordHasheada;
                db.SaveChanges();
                return true;
            }
        }
    }
}
