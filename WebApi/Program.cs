using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Configure the HTTP request pipeline.

builder.Services.AddTransient<IUserService, UserService >();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IPasswordService, PasswordService>();
builder.Services.AddDbContext<StoreExContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
    ("Data Source=srv2\\pupils;Initial Catalog=Store-Ex;Integrated Security=True;Trust Server Certificate=True")), ServiceLifetime.Transient);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
