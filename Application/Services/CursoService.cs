using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Application.Services;

public class CursoService : ICursoService
{
    private readonly ICursoRepository _cursoRepository;

    public CursoService(ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
    }

    public async Task<List<Curso>> GetAllAsync()
    {
        return (await _cursoRepository.ListAsync()).ToList();
    }

    public async Task<Curso?> GetByIdAsync(int id)
    {
        return await _cursoRepository.GetByIdAsync(id);
    }

    public async Task<Curso?> GetByCodigoAsync(string codigo)
    {
        return await _cursoRepository.GetByCodigoAsync(codigo);
    }

    public async Task AddAsync(Curso curso)
    {
        await _cursoRepository.AddAsync(curso);
    }

    public async Task UpdateAsync(Curso curso)
    {
        await _cursoRepository.Update(curso);
    }

    public async Task DeleteAsync(int id)
    {
        var curso = await _cursoRepository.GetByIdAsync(id);

        if (curso != null)
        {
            await _cursoRepository.Remove(curso);
        }
    }
}