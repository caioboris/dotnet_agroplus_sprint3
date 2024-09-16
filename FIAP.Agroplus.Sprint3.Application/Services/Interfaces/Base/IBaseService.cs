namespace FIAP.Agroplus.Sprint3.Application.Services.Interfaces.Base;

public interface IBaseService<T>
{
    Task<T?> GetAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<bool> InsertAsync(T model);
    Task<bool> UpdateAsync(Guid id, T model);
    Task<bool> DeleteAsync(Guid id);
}
