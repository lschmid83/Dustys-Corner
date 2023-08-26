using DustysCorner.Client;
using DustysCorner.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DustysCorner.MVC.Controllers
{
    public class ContactController : BaseController
    {
        private readonly SmtpSettings smtpSettings;

        public ContactController(IWebApiCalls webApiCalls, SmtpSettings smtpSettings) : base(webApiCalls)
        {
            this.smtpSettings = smtpSettings;
        }

        [Route("~/contact")]
        public async Task<IActionResult> Index()
        {
            var model = await CreateBaseModel<ContactViewModel>();
            return View(model);
        }

        [HttpPost]
        [Route("~/contact/send")]
        public IActionResult Send(string name, string email, string message)
        {
            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(smtpSettings.Address)
            };
            mail.To.Add(smtpSettings.Address);
            mail.Subject = "Contact Form";
            mail.Body = "Name: " + name + Environment.NewLine +
                        "Email: " + email + Environment.NewLine + 
                        "Message: " + Environment.NewLine + message;

            var client = new SmtpClient(smtpSettings.Host, smtpSettings.Port)
            {
                Credentials = new NetworkCredential(smtpSettings.Address, smtpSettings.Password),
                EnableSsl = true
            };
            client.Send(mail);

            return Redirect("~/");
        }
    }
}
