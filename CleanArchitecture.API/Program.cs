using CleanArchitecture.Infrastracture.Models;
using CleanArchitecture.Infrastracture.Models.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration["ConnectionStrings:DbConnection"];

if (!string.IsNullOrEmpty(connectionString))
{
    builder.Services.AddDbContext<AppDbContext>(opts =>
    {
        opts.UseSqlServer(connectionString);
    });
}

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.MapDefaultControllerRoute();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        SeedData.EnsurePopulated(context);
    }
    catch (Exception)
    {
        Console.WriteLine("An error occurred while seeding the database.");
    }
}

app.Run();
