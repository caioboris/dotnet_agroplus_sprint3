using FIAP.Agroplus.Sprint3.Domain.Contracts.Repositories;
using FIAP.Agroplus.Sprint3.Domain.Entities;
using FIAP.Agroplus.Sprint3.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FIAP.Agroplus.Sprint3.Infrastructure.Data.Repositories;

public class RegiaoRepository : IRegiaoRepository
{
    private readonly DataContext _dataContext;

    public RegiaoRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        _dataContext.Remove(id);
        var result = await _dataContext.SaveChangesAsync();
        return result > 0;
    }

    public async Task<IEnumerable<RegiaoEntity>> GetAllAsync() =>
        await _dataContext.Regioes.ToListAsync();

    public async Task<RegiaoEntity?> GetByIdAsync(Guid id) =>
        await _dataContext.Regioes.FindAsync(id);

    public async Task<bool> InsertAsync(RegiaoEntity entity)
    {
        _dataContext.Regioes.Add(entity);
        var result = await _dataContext.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> UpdateAsync(RegiaoEntity entity)
    {
        _dataContext.Regioes.Update(entity);
        var result = await _dataContext.SaveChangesAsync();
        return result > 0;
    }
}
