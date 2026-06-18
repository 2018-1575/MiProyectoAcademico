using LP3.BlazorServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LP3.BlazorServer.Data.Repositories;

public class CursoRepository : Repository<Curso>, ICursoRepository
{
    private readonly ApplicationDbContext _context;

    public CursoRepository(ApplicationDbContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<Curso?> GetByCodigoAsync(string codigo)
    {
        return await _context.Cursos
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Codigo == codigo);
    }
}