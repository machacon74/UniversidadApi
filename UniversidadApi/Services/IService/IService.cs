using UniversidadApi.Models;

namespace UniversidadApi.Services.IService
{
    public interface IService<T, TId>
    {
        Task<List<T>> GetAll();
        Task<T?> GetById(TId id);
        Task<T?> Add(T entity);
        Task<T?> Update(T entity);
    }
}
