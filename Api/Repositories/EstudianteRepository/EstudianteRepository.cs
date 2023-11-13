using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using UniversidadApi.Models;
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
