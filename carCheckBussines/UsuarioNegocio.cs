using carCheckData;
using carCheckEntities;
using carCheckServicios;
using System.Net.NetworkInformation;

namespace carCheckBussines
{
    public class UsuarioNegocio
    {
        private readonly UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool Registrar(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) ||
                string.IsNullOrWhiteSpace(usuario.Email) ||
                string.IsNullOrWhiteSpace(usuario.PasswordHash) ||
                string.IsNullOrWhiteSpace(usuario.PinHash))
            {
                return false;
            }

            if (usuario.PinHash.Length < 4)
            {
                return false;
            }

            // 🔐 Hashear password
            usuario.PasswordHash = Seguridad.HashearPassword(usuario.PasswordHash);

            // 🔐 Hashear PIN
            usuario.PinHash = Seguridad.HashearPassword(usuario.PinHash);

            usuarioDatos.Registrar(usuario);

            return true;
        }

        public Usuario Login(string email, string password)
        {
            string passwordHasheada = Seguridad.HashearPassword(password);
            return usuarioDatos.Login(email, passwordHasheada);
        }

        public bool RecuperarContrasena(string email, string pin, string nuevaContrasena, string confirmacionContrasena, out string mensaje)
        {
            mensaje = string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                mensaje= "Debes ingresar un correo electrónico.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(pin))
            {
                mensaje = "Debes ingresar el PIN.";
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
            var usuario = usuarioDatos.ObtenerPorEmail(email);

            if (usuario == null)
            {
                mensaje = "No se encontró un usuario con ese correo.";
                return false;
            }


            // 🔐 VALIDAR PIN
            bool pinValido = Seguridad.VerificarPassword(pin, usuario.PinHash);

            if (!pinValido)
            {
                mensaje = "PIN incorrecto.";
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

        public bool ConfigurarPin(string email, string pin, out string mensaje)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(pin))
            {
                mensaje = "PIN inválido";
                return false;
            }

            var usuario = usuarioDatos.ObtenerPorEmail(email);

            if (usuario == null)
            {
                mensaje = "Usuario no encontrado";
                return false;
            }

            if (!string.IsNullOrEmpty(usuario.PinHash))
            {
                mensaje = "El usuario ya tiene un PIN configurado";
                return false; // 👈 clave
            }

            string hash = Seguridad.HashearPassword(pin);
            bool ok = usuarioDatos.ConfigurarPin(email, hash);

            if (!ok)
            {
                mensaje = "Error al guardar el PIN";
                return false;
            }

            mensaje = "PIN configurado correctamente";
            return true;
        }

    }
}