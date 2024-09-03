using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Minimal.API.Domain.Interfaces;
using Minimal.API.Domain.Services;
using MinimalAPI.Domain.DTOs;
using MinimalAPI.Infrastructure.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServicos, AdministradorServicos>();

builder.Services.AddDbContext<DbCarContext>(
  options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServicos administradorServicos) =>
{
  if (administradorServicos.Login(loginDTO) != null)
    return Results.Ok("Successful login!");
  else
    return Results.Unauthorized();
});


app.Run();

