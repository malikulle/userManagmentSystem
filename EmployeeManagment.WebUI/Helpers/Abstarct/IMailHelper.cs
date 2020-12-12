using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.WebUI.Helpers.Abstarct
{
    public interface IMailHelper
    {
        Task<bool> SendMailAsync(string email, string subject, string htmlMessage);
    }
}
