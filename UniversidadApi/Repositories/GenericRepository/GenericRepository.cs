using Microsoft.EntityFrameworkCore.ChangeTracking;
using UniversidadApi.Models;

namespace UniversidadApi.Repositories.GenericRepository
{
    public class GenericRepository<T, TId> : IGenericRepository<T, TId> 
        where T : BaseEntity<TId> 
        where TId : IEquatable<TId>
    {
        private readonly DbContext _context;
        protected DbSet<T> DataSet => _context.Set<T>();

        public IQueryable<T> GetAll() => DataSet;

        public Task<T?> GetByID(TId id) => DataSet.FirstOrDefaultAsync<T>(e => e.Id.Equals(id));

        public async Task<T?> Add(T entity)
        {
            EntityEntry<T> result = await DataSet.AddAsync(entity);
            return result.Entity;
        }
        
        public T? Update(T entity)
        {
            EntityEntry<T> result = DataSet.Update(entity);
            return result.Entity;
        }
    }
}
