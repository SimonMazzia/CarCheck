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
    }
}
