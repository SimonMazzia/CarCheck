using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace carCheckServicios
{
    public static class ServicioCorreo
    {
        public static void EnviarRecuperacion(string email, string token)
        {
            var mensaje = new MailMessage();
            mensaje.From = new MailAddress("tuCorreo@dominio.com");
            mensaje.To.Add(email);
            mensaje.Subject = "Recuperación de contraseña";
            mensaje.Body = $"Usa este token para recuperar tu contraseña: {token}";
            var smtp = new SmtpClient("smtp.dominio.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("tuCorreo@dominio.com", "tuPassword"),
                EnableSsl = true

            };
            smtp.Send(mensaje);
        }
    }
}
