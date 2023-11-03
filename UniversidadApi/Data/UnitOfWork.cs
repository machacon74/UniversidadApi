using UniversidadApi.Repositories.AsignaturaRepository;
using UniversidadApi.Repositories.EstudianteRepository;
using UniversidadApi.Repositories.GeneroRepository;

namespace UniversidadApi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public IGeneroRepository GeneroRepository { get; }
        public IAsignaturaRepository AsignaturaRepository { get; }
        public IEstudianteRepository EstudianteRepository { get; }
        
        Task<int> SaveChanges();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IGeneroRepository GeneroRepository { get; }
        public IAsignaturaRepository AsignaturaRepository { get; }
        public IEstudianteRepository EstudianteRepository { get; }

        public UnitOfWork(DbContext context, IGeneroRepository generoRepository, IAsignaturaRepository asignaturaRepository, IEstudianteRepository estudianteRepository)
        {
            _context = context;
            GeneroRepository = generoRepository;
            AsignaturaRepository = asignaturaRepository;
            EstudianteRepository = estudianteRepository;
        }

        public void Dispose() => _context.Dispose();

        public async Task<int> SaveChanges() => await _context.SaveChangesAsync();
    }
}
