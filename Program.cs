using ApiGestaoProcessos.Data;
using ApiGestaoProcessos.Profiles;
using ApiGestaoProcessos.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração do Entity Framework Core com MySql
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, serverVersion));

// Configuração de AutoMapper
builder.Services.AddAutoMapper(config => config.AddProfile<AppProfile>());

// Registro de Services
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<MarcacaoService>();

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.MapControllers();

app.Run();