using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace MiProyectoAcademico.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Matriculacion> Matriculaciones { get; set; }
    }
}