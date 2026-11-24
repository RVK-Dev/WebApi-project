using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddTransient<IOrdersReposetory, OrdersReposetory>();
builder.Services.AddTransient<IOrdersService, OrdersService>();

builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddTransient<IProductsReposetory, ProductsReposetory>();

builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ICatagoryReposetory, CatagoryReposetory>();

builder.Services.AddTransient<IUserService, UserService >();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddTransient<IPasswordService, PasswordService>();

builder.Services.AddDbContext<StoreExContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
    ("Data Source=srv2\\pupils;Initial Catalog=Store-Ex;Integrated Security=True;Trust Server Certificate=True")), ServiceLifetime.Transient);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
