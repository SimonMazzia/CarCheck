using carCheckData;
using carCheckEntities;
using carCheckServicios;

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

        public bool RecuperarPassword(string email)
        {
            try
            {
                var usuarioDatos = new UsuarioDatos();
                var usuario = usuarioDatos.ObtenerPorCorreo(email);
                if ( usuario== null)
                {
                    Console.WriteLine("No se encontró un usuario con ese correo.");
                    return false;
                }
                //generar token con guid
                String token = Guid.NewGuid().ToString();
                Console.WriteLine("Token generado para recuperación");
                //guardar token en db
                usuarioDatos.GuardarTokenRecuperacion(usuario.Id, token);
                //enviar correo con el token
                ServicioCorreo.EnviarRecuperacion(email, token);
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en recuperación de contraseña: {ex.Message}");
                return false;
            }
        }
    }
}