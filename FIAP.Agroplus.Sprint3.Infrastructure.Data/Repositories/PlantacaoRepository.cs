using FIAP.Agroplus.Sprint3.Domain.Contracts.Repositories;
using FIAP.Agroplus.Sprint3.Domain.Entities;
using FIAP.Agroplus.Sprint3.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FIAP.Agroplus.Sprint3.Infrastructure.Data.Repositories;

public class PlantacaoRepository : IPlantacaoRepository
{
    private readonly DataContext _dataContext;

    public PlantacaoRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<bool> DeleteAsync(PlantacaoEntity entity)
    {
        _dataContext.Remove(entity);
        var result = await _dataContext.SaveChangesAsync();
        return result > 0;
    }

    public async Task<IEnumerable<PlantacaoEntity>> GetAllAsync() =>
        await _dataContext.Plantacoes.ToListAsync();

    public async Task<PlantacaoEntity?> GetByIdAsync(Guid id) =>
        await _dataContext.Plantacoes.FindAsync(id);

    public async Task<bool> InsertAsync(PlantacaoEntity entity)
    {
        _dataContext.Plantacoes.Add(entity);
        var result = await _dataContext.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> UpdateAsync(PlantacaoEntity entity)
    {
        _dataContext.Plantacoes.Update(entity);
        var result = await _dataContext.SaveChangesAsync();
        return result > 0;
    }
}
