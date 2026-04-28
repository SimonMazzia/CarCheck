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

        public bool ExisteEmail(string email)
        {
            using (var db = new CarCheckDbContext())
            {
                return db.Usuarios.Any(u => u.Email == email);
            }
        }

        public Usuario ObtenerPorEmail(string email)
        {
            using (var db = new CarCheckDbContext())
            {
                return db.Usuarios.FirstOrDefault(u => u.Email == email);
            }
        }
        public bool ActualizarPassword(string email, string nuevaContrasenaHasheada)
        {
            using (var db = new CarCheckDbContext())
            {
                Usuario? usuario = db.Usuarios.FirstOrDefault(u => u.Email == email);
                if (usuario == null)
                {
                    return false;
                }
                usuario.PasswordHash = nuevaContrasenaHasheada;

                db.SaveChanges();
                return true;
            }
        }
        public bool ConfigurarPin(string email, string pinHash)
        {
            using (var db = new CarCheckDbContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u => u.Email == email);
                if (usuario == null)
                
                    return false;
                

                if  (!string.IsNullOrEmpty(usuario.PinHash))
                
                    return false;


                usuario.PinHash = pinHash;
                db.SaveChanges();

                return true;

                }
            }
        }
    } 

