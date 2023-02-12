namespace DependencyInjectionInAspNet.Services;
public sealed class EmailService : IEmailService
{

	public void SendEmail(User user)
	{
		Console.WriteLine($"Sending email to {user.Email}:");
		Console.WriteLine($"Welcome aboard {user.Name}");
	}
}
