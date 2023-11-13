using Entity.Models;
using UniversidadApi.Repositories.GenericRepository;

namespace UniversidadApi.Repositories.AsignaturaRepository
{
    public class AsignaturaRepository : GenericRepository<Asignatura, int>, IAsignaturaRepository
    {
        public AsignaturaRepository(DbContext context) : base(context)
        {
        }
    }
}
