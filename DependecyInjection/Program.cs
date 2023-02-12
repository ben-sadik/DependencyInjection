using DependecyInjection;
using DependecyInjection.Services;

var service = new WithDI(
	new FriendlyEmailService(),
	new UserValidator(),
	new UserRepository()
	);

var user = new User(
	"Youssef BEN SADIK", 
	"youssef@bensadik.net");

service.Register(user);
