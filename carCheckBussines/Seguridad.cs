using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace carCheckBussines
{
    public static class Seguridad
    {
        public static object BCrypt { get; private set; }

        public static string HashearPassword(string PasswordHash)
            {
              using (SHA256 sha256 = SHA256.Create())
               {
                byte[] bytes = Encoding.UTF8.GetBytes(PasswordHash);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }
                    return builder.ToString();
                }

            }
        public static bool VerificarPassword(string input, string hashGuardado)
        {
            string hashInput = HashearPassword(input);
            return hashInput == hashGuardado;
        }
    }
    }
