namespace DependencyInjectionInAspNet.Services;
public sealed class UserValidator : IUserValidator
{
	public void Validate(User user)
	{
		Console.WriteLine($"User \"{user.Name}\" is valid");
	}
}
