using Microsoft.EntityFrameworkCore;
using MiProyectoAcademico.Data;
using MiProyectoAcademico.Domain.Entities;	

namespace MiProyectoAcademico.Data.Repositories;

public class EstudianteRepository(ApplicationDbContext context)
 : Repository<Estudiante>(context) , IEstudianteRepository
{
	private readonly ApplicationDbContext _context = context;
		public async Task<Estudiante?> GetByMatriculaAsync(string matricula)
	{
		return await _context.Estudiantes
			.AsNoTracking()
			.FirstOrDefaultAsync(e => e.Matricula == matricula);
	}
}