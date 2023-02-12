using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection.Services;
internal class FriendlyEmailService : IEmailService
{
    public void SendEmail(User user)
    {
        Console.WriteLine($"Sending email to {user.Email}:");
        Console.WriteLine($"Welcome to the family {user.Name}");
    }
}
