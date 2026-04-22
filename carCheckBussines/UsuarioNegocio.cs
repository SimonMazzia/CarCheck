using carCheckData;
using carCheckEntities;
using carCheckServicios;

namespace carCheckBussines
{
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool Registrar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) ||
             string.IsNullOrWhiteSpace(usuario.Email) ||
             string.IsNullOrWhiteSpace(usuario.PasswordHash))
            {
                return false;
            }
            usuario.PasswordHash = Seguridad.HashearPassword(usuario.PasswordHash);
            using (var db = new CarCheckDbContext())
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

        public bool RecuperarContrasena(string email, string nuevaContrasena, string confirmacionContrasena, out string mensaje)
        {
            mensaje = string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                mensaje= "Debes ingresar un correo electrónico.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nuevaContrasena) || string.IsNullOrWhiteSpace(confirmacionContrasena))
            {
                mensaje = "Debes ingresar la nueva contraseña y su confirmación.";
                return false;
            }
                
            if (nuevaContrasena != confirmacionContrasena)
            {
                mensaje = "La nueva contraseña y su confirmación no coinciden.";
                return false;
            }
            if (nuevaContrasena.Length < 6)
            {
                mensaje = "La nueva contraseña debe tener al menos 6 caracteres.";
                return false;
            }
            if (!usuarioDatos.ExisteEmail(email))
            {
                mensaje = "No se encontró un usuario con ese correo electrónico.";
                return false;
            }
            
            string nuevaContrasenaHasheada = Seguridad.HashearPassword(nuevaContrasena);
            bool actualizada = usuarioDatos.ActualizarPassword(email, nuevaContrasenaHasheada);
            if (!actualizada)
            {
                mensaje = "No se pudo actualizar la contraseña. Inténtalo de nuevo.";
                return false;
            }
            mensaje= "Contraseña actualizada exitosamente.";
            return true;

        }

    }
}