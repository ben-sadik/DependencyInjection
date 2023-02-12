namespace DependencyInjectionInAspNet.Services;
public sealed class UserRepository : IUserRepository 
{
	public void Save(User user) 
	{
		Console.WriteLine($"Saving user {user.Name} to database");
	} 
}
