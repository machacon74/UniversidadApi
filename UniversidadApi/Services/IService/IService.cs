using UniversidadApi.Models;

namespace UniversidadApi.Services.IService
{
    public interface IService<T, TId>
    {
        Task<RespuestaGeneral> GetAll();
        Task<RespuestaGeneral> GetById(TId id);
        Task<RespuestaGeneral> Add(T entity);
        Task<RespuestaGeneral> Update(T entity);
    }
}
