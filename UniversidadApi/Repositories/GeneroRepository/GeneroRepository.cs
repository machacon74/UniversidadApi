using UniversidadApi.Models;
using UniversidadApi.Repositories.GenericRepository;

namespace UniversidadApi.Repositories.GeneroRepository
{
    public class GeneroRepository : GenericRepository<Genero, short>, IGeneroRepository
    {
        public GeneroRepository(DbContext context) : base(context) { }
    }
}
