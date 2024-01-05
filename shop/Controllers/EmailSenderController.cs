using Microsoft.AspNetCore.Mvc;

namespace shop.Controllers
{
    public class EmailSenderController : Controller
    {
        private readonly IEmailSender _emailSender;

        public EmailSenderController(IEmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        public async Task<IActionResult> Temp()
        {
            var reciever = "shishegar.abalfazl@gmail.com";
            var subject = "Welcome";
            var message = "Welcome to shop!";

            await _emailSender.SendEmailAsync(reciever, subject, message);

            return View();
        }
    }
}
