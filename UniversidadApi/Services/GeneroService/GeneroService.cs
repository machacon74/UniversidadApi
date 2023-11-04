using UniversidadApi.Models;

namespace UniversidadApi.Services.GeneroService
{
    public class GeneroService : IGeneroService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GeneroService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Genero>> GetAll()
        {
            return await _unitOfWork.GeneroRepository.GetAll().ToListAsync();
        }

        public async Task<Genero?> GetById(short id)
        {
            return await _unitOfWork.GeneroRepository.GetByID(id);
        }
        
        public async Task<Genero?> Add(Genero entity)
        {
            var genero = await _unitOfWork.GeneroRepository.Add(entity);
            await _unitOfWork.SaveChanges();
            return genero;
        }

        public async Task<Genero?> Update(Genero entity)
        {
            var genero = _unitOfWork.GeneroRepository.Update(entity);
            await _unitOfWork.SaveChanges();
            return genero;
        }
    }
}
