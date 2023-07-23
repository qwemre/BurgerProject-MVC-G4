using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;

namespace BurgerProject_MVC_G4
{
    public class EmailSender : IEmailSender
    {
        private readonly SmtpClient _smtpClient;

        public EmailSender()
        {
            _smtpClient = new SmtpClient("smtp.gmail.com", 587);
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.EnableSsl = true;
            _smtpClient.Credentials = new NetworkCredential("emrekaraomeroglu@gmail.com", "ccdvxjjerjyajgdz");
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage("emrekaraomeroglu@gmail.com", email, subject, htmlMessage);
            message.IsBodyHtml = true;
            return _smtpClient.SendMailAsync(message);
        }
    }
}
