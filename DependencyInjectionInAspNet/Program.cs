using DependencyInjectionInAspNet;
using DependencyInjectionInAspNet.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserValidator, UserValidator>();
builder.Services.AddScoped<IEmailService, FriendlyEmailService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.MapGet("/", (IUserService userService) =>
{
	var user = new User(
		"Youssef BEN SADIK", 
		"youssef@bensadik.net");
	userService.Register(user);
});

app.Run();