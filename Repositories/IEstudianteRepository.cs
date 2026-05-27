using MiProyectoAcademico.Domain.Entities;	

namespace MiProyectoAcademico.Data.Repositories;

public interface IEstudianteRepository : IRepository<Estudiante>
{
	Task<Estudiante?> GetByMatriculaAsync(string matricula);
}