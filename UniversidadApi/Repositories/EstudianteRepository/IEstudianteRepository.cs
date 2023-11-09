using UniversidadApi.Models;
using UniversidadApi.Repositories.GenericRepository;

namespace UniversidadApi.Repositories.EstudianteRepository
{
    public interface IEstudianteRepository : IGenericRepository<Estudiante, int>
    {
    }
}
