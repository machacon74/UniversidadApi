using Entity.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace UniversidadApi.Repositories.GenericRepository
{
    public abstract class GenericRepository<T, TId> : IGenericRepository<T, TId> 
        where T : BaseEntity<TId> 
        where TId : IEquatable<TId>
    {
        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

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

        public async Task<bool> Exists(TId id) => await DataSet.AnyAsync(e => e.Id.Equals(id));
    }
}
