using DependecyInjection.Services;

namespace DependecyInjection;
public sealed class WithIoC
{
    public void Register(User user, IEmailService emailService)
    {
        Validate(user);
        SaveToDatabase(user);
        emailService.SendEmail(user);
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
}
