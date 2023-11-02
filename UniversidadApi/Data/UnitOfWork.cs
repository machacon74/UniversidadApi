using UniversidadApi.Repositories.GeneroRepository;

namespace UniversidadApi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public IGeneroRepository GeneroRepository { get; }
        Task<int> SaveChanges();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IGeneroRepository GeneroRepository { get; }

        public UnitOfWork(DbContext context, IGeneroRepository generoRepository)
        {
            _context = context;
            GeneroRepository = generoRepository;
        }

        public void Dispose() => _context.Dispose();

        public async Task<int> SaveChanges() => await _context.SaveChangesAsync();
    }
}
