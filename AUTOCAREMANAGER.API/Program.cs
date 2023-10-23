using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using AUTOCAREMANAGER.DOMAIN.Infrastructure.Data;
using AUTOCAREMANAGER.DOMAIN.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var _config = builder.Configuration;
var _cnx = _config.GetConnectionString("DevConnection");
builder
    .Services
    .AddDbContext<AutocaremanagerContext>(options =>
    {
        options.UseSqlServer(_cnx);
    });

builder.Services.AddTransient<IEmpleadoRepository,EmpleadoRepository>();
builder.Services.AddTransient<IArticuloRepository, ArticuloRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IVehiculoRepository, VehiculoRepository>();
builder.Services.AddTransient<ITallerRepository, TallerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
