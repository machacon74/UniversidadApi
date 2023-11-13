using Entity.Models;
using UniversidadApi.Repositories.GenericRepository;

namespace UniversidadApi.Repositories.EstudianteRepository
{
    public class EstudianteRepository : GenericRepository<Estudiante, int>, IEstudianteRepository
    {

        public EstudianteRepository(DbContext context) : base(context)
        {
        }
    }
}
