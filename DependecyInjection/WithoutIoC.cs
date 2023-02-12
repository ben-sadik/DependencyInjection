using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection;
public sealed class WithoutIoC
{
	public void Register(User user)
	{
		Validate(user);
		SaveToDatabase(user);
		SendEmail2(user);
	}

	private void Validate(User user)
	{
		if (user is null)
		{
			throw new ArgumentNullException(nameof(user));
		}

		if (string.IsNullOrWhiteSpace(user.Name))
		{
			throw new ArgumentException("Name is required", nameof(user));
		}

		if (string.IsNullOrWhiteSpace(user.Email))
		{
			throw new ArgumentException("Email is required", nameof(user));
		}
		Console.WriteLine($"User \"{user.Name}\" is valid");
	}
	private void SaveToDatabase(User user)
	{
		Console.WriteLine($"Saving {user.Name} to database");
	}
	private void SendEmail(User user)
	{
		Console.WriteLine($"Sending email to {user.Email}:");
		Console.WriteLine($"Welcome aboard {user.Name}");
	}
	private void SendEmail2(User user)
	{
		Console.WriteLine($"Sending email to {user.Email}:");
		Console.WriteLine($"Welcome to the family {user.Name}");
	}
}
