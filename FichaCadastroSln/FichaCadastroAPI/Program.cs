using FichaCadastroAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// String de conexão BD
string connectionString = "Server=localhost;Database=FichaCadastro;Trusted_Connection=True;TrustServerCertificate=True;";

// Injeção de dependência do contexto 
builder.Services.AddDbContext<FichaCadastroContext>(options => options.UseSqlServer(connectionString));

// Configuração do automapper
builder.Services.AddAutoMapper(typeof(Program));

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
