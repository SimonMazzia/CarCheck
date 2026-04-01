using carCheckData;
using carCheckEntities;

namespace carCheckBussines
{
    public class UsuarioNegocio
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool Registrar(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.NombreUsuario) ||
                string.IsNullOrEmpty(usuario.Email) ||
                string.IsNullOrEmpty(usuario.PasswordHash))
            { 
              return false; 
            }


            usuario.PasswordHash = Seguridad.HashearPassword(usuario.PasswordHash);
            using(var db= new CarCheckDbContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }

            return true;
        }
        

        public Usuario Login(string email, string password)
        {
            string passwordHasheada = Seguridad.HashearPassword(password);
            return usuarioDatos.Login(email, passwordHasheada);
        }
    }
}