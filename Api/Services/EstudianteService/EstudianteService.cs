using Entity.Models;

namespace UniversidadApi.Services.EstudianteService
{
    public class EstudianteService : IEstudianteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EstudianteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RespuestaGeneral> Add(Estudiante estudiante)
        {
            if(await _unitOfWork.EstudianteRepository.GetAll().AnyAsync(e => e.Identificacion.Equals(estudiante.Identificacion)))
                return new RespuestaGeneral(0, $"{nameof(Estudiante)} ya existe con esta {nameof(Estudiante.Identificacion)}");

            estudiante = await _unitOfWork.EstudianteRepository.Add(estudiante);
            await _unitOfWork.SaveChanges();
            _unitOfWork.Dispose();
            return new RespuestaGeneral(1)
            {
                DatosRespuesta = estudiante
            };
        }

        public async Task<RespuestaGeneral> GetAll()
        {
            return new RespuestaGeneral(1)
            {
                DatosRespuesta = await _unitOfWork.EstudianteRepository.GetAll().ToListAsync()
            };
        }

        public async Task<RespuestaGeneral> GetById(int id)
        {
            return new RespuestaGeneral(1)
            {
                DatosRespuesta = await _unitOfWork.EstudianteRepository.GetByID(id)
            };
        }

        public async Task<RespuestaGeneral> Update(Estudiante estudiante)
        {
            if (!await _unitOfWork.EstudianteRepository.Exists(estudiante.Id))
                return new RespuestaGeneral(0, $"{nameof(Estudiante)} no existe.");

            estudiante = _unitOfWork.EstudianteRepository.Update(estudiante);
            await _unitOfWork.SaveChanges();
            _unitOfWork.Dispose();
            return new RespuestaGeneral(1)
            {
                DatosRespuesta = estudiante
            };
        }
    }
}
