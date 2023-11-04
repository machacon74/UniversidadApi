using UniversidadApi.Models;

namespace UniversidadApi.Services.EstudianteService
{
    public class EstudianteService : IEstudianteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EstudianteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Estudiante?> Add(Estudiante estudiante)
        {
            estudiante = await _unitOfWork.EstudianteRepository.Add(estudiante);
            await _unitOfWork.SaveChanges();
            return estudiante;
        }

        public async Task<List<Estudiante>> GetAll()
        {
            return await _unitOfWork.EstudianteRepository.GetAll().ToListAsync();
        }

        public async Task<Estudiante?> GetById(int id)
        {
            return await _unitOfWork.EstudianteRepository.GetByID(id);
        }

        public async Task<Estudiante?> Update(Estudiante estudiante)
        {
            estudiante = _unitOfWork.EstudianteRepository.Update(estudiante);
            await _unitOfWork.SaveChanges();
            return estudiante;
        }
    }
}
