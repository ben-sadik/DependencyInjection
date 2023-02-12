using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection.Services;
public interface IEmailService
{
    void SendEmail(User user);
}
