using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Configure the HTTP request pipeline.

builder.Services.AddTransient<IUserService, UserService >();
//The assignment asks the API to use the service, not the repository: the API project references Services, and Services references Repositories
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IPasswordService, PasswordService>();
var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
