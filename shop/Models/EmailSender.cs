using shop.Controllers;
using System.Net;
using System.Net.Mail;

namespace shop.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message) {
            var mail = "UiWebFall";
            var pw = "qwertyu1234567";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(from: mail,
                to: email,
                subject,
                message
                ));
        }
    }
}
