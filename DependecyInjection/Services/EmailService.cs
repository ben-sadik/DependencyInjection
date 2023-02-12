using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection.Services;
public sealed class EmailService : IEmailService
{
    public void SendEmail(User user)
    {
        Console.WriteLine($"Sending email to {user.Email}:");
        Console.WriteLine($"Welcome aboard {user.Name}");
    }
}
