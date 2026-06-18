using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Application.Services;

public interface ICursoService
{
    Task<List<Curso>> GetAllAsync();
    Task<Curso?> GetByIdAsync(int id);
    Task<Curso?> GetByCodigoAsync(string codigo);
    Task AddAsync(Curso curso);
    Task UpdateAsync(Curso curso);
    Task DeleteAsync(int id);
}