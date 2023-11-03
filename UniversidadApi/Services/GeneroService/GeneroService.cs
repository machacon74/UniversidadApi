using UniversidadApi.Models;

namespace UniversidadApi.Services.GeneroService
{
    public class GeneroService : IGeneroService
    {
        IUnitOfWork UnitOfWork { get; }

        public GeneroService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public async Task<List<Genero>> GetAllGeneros()
        {
            return await UnitOfWork.GeneroRepository.GetAll().ToListAsync();
        }

        public async Task<Genero?> GetGenero(short id)
        {
            return await UnitOfWork.GeneroRepository.GetByID(id);
        }
        
        public async Task<Genero?> AddGenero(Genero entity)
        {
            var genero = await UnitOfWork.GeneroRepository.Add(entity);
            await UnitOfWork.SaveChanges();
            return genero;
        }

        public async Task<Genero?> UpdateGenero(Genero entity)
        {
            var genero = UnitOfWork.GeneroRepository.Update(entity);
            await UnitOfWork.SaveChanges();
            return genero;
        }
    }
}
