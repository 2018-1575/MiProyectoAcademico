using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MiProyectoAcademico.Domain.Entities;

namespace MiProyectoAcademico.Data
{
    public class ApplicationDbContext
    (DbContextOptions<ApplicationDbContext> options) :
     IdentityDbContext<ApplicationUser> (options)
    {

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Matriculacion> Matriculaciones { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}