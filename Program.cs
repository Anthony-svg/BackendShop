using Microsoft.EntityFrameworkCore;
using WebApp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var OrigenesPermitidos = builder.Configuration.GetValue<string>("OrigenesPermitidos")!.Split(',');

builder.Services.AddCors(opciones => 
{
    opciones.AddDefaultPolicy(politica =>
    {
        politica.WithOrigins(OrigenesPermitidos).AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddDbContext<ApplicarionDbContext>(opciones => opciones.UseSqlServer("name=DefaultConnection"));
//builder.Services.AddSingleton(provider => builder.Configuration.GetConnectionString("CadenaSql"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

