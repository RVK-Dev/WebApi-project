using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Configure the HTTP request pipeline.

builder.Services.AddTransient<IUserService, UserService >();
builder.Services.AddTransient<IUserRepository, UserRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
