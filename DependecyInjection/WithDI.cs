using DependecyInjection.Services;

namespace DependecyInjection;
public sealed class WithDI
{
    private readonly IEmailService _emailService;
	private readonly IUserValidator _validator;
	private readonly IUserRepository _userRepository;

	public WithDI(IEmailService emailService, IUserValidator validator, IUserRepository userRepository)
	{
		_emailService = emailService;
		_validator = validator;
		_userRepository = userRepository;
	}

	public void Register(User user)
	{
		_validator.Validate(user);
		_userRepository.Save(user);
		_emailService.SendEmail(user);
	}
}
