using UniversidadApi.Models;

namespace UniversidadApi.Services.CalificacionService
{
    public class CalificacionService : ICalificacionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CalificacionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Calificacion?> Add(Calificacion calificacion)
        {
            calificacion = await _unitOfWork.CalificacionRepository.Add(calificacion);
            return calificacion;
        }

        public async Task<List<Calificacion>> GetAll()
        {
            return await _unitOfWork.CalificacionRepository.GetAll().ToListAsync();
        }

        public async Task<Calificacion?> GetById(int id)
        {
            return await _unitOfWork.CalificacionRepository.GetByID(id);
        }

        public async Task<Calificacion?> Update(Calificacion calificacion)
        {
            calificacion = _unitOfWork.CalificacionRepository.Update(calificacion);
            return calificacion;
        }
    }
}
