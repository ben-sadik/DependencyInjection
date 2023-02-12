using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection.Services;
internal class UserRepository : IUserRepository
{
	public void Save(User user)
	{
		Console.WriteLine($"Saving user {user.Name} to database");
	}
}
