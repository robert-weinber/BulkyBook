using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Utility.Emailer
{
    public interface IMailService
    {
        Task SendEmailAsync(string mail, string subject, string message);
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
