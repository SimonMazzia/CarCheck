using carCheckEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Usuario ObtenerPorCorreo(string email)
        {
            try
            {
                using (var context = new CarCheckDbContext())
                {
                    return context.Usuarios.FirstOrDefault(u => u.Email == email);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, registrar el error)
                Console.WriteLine($"Error al obtener el usuario por correo: {ex.Message}");
                return null;
            }
        }
    
        public void GuardarTokenRecuperacion(int usuarioId, string token)
        { 
          using (var context = new CarCheckDbContext())
            {
                var usuario = context.Usuarios.Find(usuarioId);
                if (usuario != null)
                {
                    usuario.TokenRecuperacion = token;
                    context.SaveChanges();
                }
            }

        }
    } 
}
