using Microsoft.EntityFrameworkCore;
using MiProyectoAcademico.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));

var app = builder.Build();

app.MapGet("/", () => "API funcionando 🔥");

app.Run();