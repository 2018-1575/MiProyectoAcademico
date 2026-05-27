using Microsoft.EntityFrameworkCore;
using MiProyectoAcademico.Data;
using MiProyectoAcademico.Data.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));
    builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    builder.Services.AddScoped<IEstudianteRepository, EstudianteRepository>();
    

var app = builder.Build();

app.MapGet("/", () => "API funcionando 🔥");

app.Run();

