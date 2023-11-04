using UniversidadApi.Models;

namespace UniversidadApi.Services.AsignaturaService
{
    public class AsignaturaService : IAsignaturaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AsignaturaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Asignatura>> GetAll()
        {
            return await _unitOfWork.AsignaturaRepository.GetAll().ToListAsync();
        }

        public async Task<Asignatura?> GetById(int id)
        {
            return await _unitOfWork.AsignaturaRepository.GetByID(id);
        }

        public async Task<Asignatura?> Add(Asignatura entity)
        {
            var genero = await _unitOfWork.AsignaturaRepository.Add(entity);
            await _unitOfWork.SaveChanges();
            return genero;
        }

        public async Task<Asignatura?> Update(Asignatura entity)
        {
            var genero = _unitOfWork.AsignaturaRepository.Update(entity);
            await _unitOfWork.SaveChanges();
            return genero;
        }
    }
}
