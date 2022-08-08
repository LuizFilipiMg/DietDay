using AutoMapper;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServico;
using Dominio.Servicos;
using Entidades;
using Entidades.Mapping;
using InfraEstrutura.Repositorio;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(UsuariosProfile));
builder.Services.AddScoped<IServicoUsuarios, ServicoUsuarios>();
builder.Services.AddScoped<IUsuarios, UsuariosRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
