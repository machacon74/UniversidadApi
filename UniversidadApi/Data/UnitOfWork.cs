using UniversidadApi.Repositories.AsignaturaRepository;
using UniversidadApi.Repositories.GeneroRepository;

namespace UniversidadApi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public IGeneroRepository GeneroRepository { get; }
        public IAsignaturaRepository AsignaturaRepository { get; }
        Task<int> SaveChanges();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IGeneroRepository GeneroRepository { get; }
        public IAsignaturaRepository AsignaturaRepository { get; }

        public UnitOfWork(DbContext context, IGeneroRepository generoRepository, IAsignaturaRepository asignaturaRepository)
        {
            _context = context;
            GeneroRepository = generoRepository;
            AsignaturaRepository = asignaturaRepository;
        }

        public void Dispose() => _context.Dispose();

        public async Task<int> SaveChanges() => await _context.SaveChangesAsync();
    }
}
