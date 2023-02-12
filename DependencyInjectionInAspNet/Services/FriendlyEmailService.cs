namespace DependencyInjectionInAspNet.Services;
internal class FriendlyEmailService : IEmailService
{
	public void SendEmail(User user)
	{
		Console.WriteLine($"Sending email to {user.Email}:");
		Console.WriteLine($"Welcome to the family {user.Name}");
	}
}
