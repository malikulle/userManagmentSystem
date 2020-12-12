using EmployeeManagment.WebUI.Helpers.Abstarct;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.WebUI.Helpers.Concrete
{
    public class EmailManager : IMailHelper
    {
        private IOptions<appSettings_json> _configuration { get; }

        public EmailManager(IOptions<appSettings_json> configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> SendMailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(_configuration.Value.SendGridApiKey);
            var from = new EmailAddress("employemanager@noktaatisi.com","Çalışan Takip Sistemi");
            var to = new EmailAddress(email, "Son Kullanıcı");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
            await client.SendEmailAsync(msg);
            return true;
        }
    }
}
