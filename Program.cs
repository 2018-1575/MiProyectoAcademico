using Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<Estudiante> estudiantes = new()
{
    new Estudiante
    {
        Id = 1,
        Nombre = "Juan",
        Apellido = "Perez"
    },
    new Estudiante
    {
        Id = 2,
        Nombre = "Maria",
        Apellido = "Lopez"
    }
};

app.MapGet("/", () => "Proyecto funcionando");

app.MapGet("/estudiantes", () =>
{
    return estudiantes;
});

app.Run();