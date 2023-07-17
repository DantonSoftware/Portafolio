using Portafolio.Models;
using System.Net.Mail;

namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }
    public class ServicioEmail: IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");
            var Password = configuration.GetValue<string>("SENDGRID_PASSWORD");
            //quitar los espacios entre smtp y antes del com
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            client.Credentials = new System.Net.NetworkCredential(email, Password);

            var from = email;
            var subject = $"El cliente {contacto.Email} quiere contactarte ";
            var to = email;
            var mensajeTextoPlano = contacto.Mensaje;
            var contenidoHtml = @$"De: {contacto.Nombre} - Email: {contacto.Email} Mensaje: {contacto.Mensaje}";
            MailMessage message = new MailMessage(from, to, subject, contenidoHtml);
            client.Send(message);
        }


    }
}
