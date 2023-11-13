namespace UniversidadApi.Repositories.GenericRepository
{
    public interface IGenericRepository<T, TId>
    {
        IQueryable<T> GetAll();
        Task<T?> GetByID(TId id);
        Task<T?> Add(T entity);
        T? Update(T entity);
        Task<bool> Exists(TId id);
    }
}
