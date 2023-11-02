using UniversidadApi.Models;
using UniversidadApi.Repositories.GenericRepository;

namespace UniversidadApi.Repositories.GeneroRepository
{
    public class GeneroRepository : GenericRepository<Genero, int>, IGeneroRepository
    {
        public GeneroRepository(DbContext context) : base(context) { }
    }
}
