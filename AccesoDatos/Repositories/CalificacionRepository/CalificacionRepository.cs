using Entity.Models;
using UniversidadApi.Repositories.GenericRepository;

namespace UniversidadApi.Repositories.CalificacionRepository
{
    public class CalificacionRepository : GenericRepository<Calificacion, int>, ICalificacionRepository
    {
        public CalificacionRepository(DbContext context) : base(context)
        {
        }
    }
}
