using Aplicacao;
using Aplicacao.Interfaces;
using Dominio.Interfaces.InterfacesServico;
using Dominio.Mapping;
using Dominio.Servicos;
using InfraEstrutura.InterfaceRepository;
using InfraEstrutura.Repository;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(UsuariosProfile));
builder.Services.AddScoped<IServicoUsuarios, ServicoUsuarios>();
builder.Services.AddScoped<IUsuariosRepository, UsuariosRepository>();
builder.Services.AddScoped<IAplicacaoUsuario, AplicacaoUsuario>();


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
