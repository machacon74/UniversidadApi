using UniversidadApi.Models;

namespace UniversidadApi.Services.AsignaturaService
{
    public class AsignaturaService : IAsignaturaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public AsignaturaService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<RespuestaGeneral> GetAll()
        {
            return new RespuestaGeneral(1) { DatosRespuesta = await _unitOfWork.AsignaturaRepository.GetAll().ToListAsync() };
        }

        public async Task<RespuestaGeneral> GetById(int id)
        {
            return new RespuestaGeneral(1) { DatosRespuesta = await _unitOfWork.AsignaturaRepository.GetByID(id) };
        }

        public async Task<RespuestaGeneral> Add(Asignatura asignatura)
        {
            asignatura = await _unitOfWork.AsignaturaRepository.Add(asignatura);
            await _unitOfWork.SaveChanges();
            return new RespuestaGeneral(1)
            {
                DatosRespuesta = asignatura
            };
        }

        public async Task<RespuestaGeneral> Update(Asignatura asignatura)
        {
            //Si la asignatura no existe
            if (!await _unitOfWork.AsignaturaRepository.Exists(asignatura.Id))
                return new RespuestaGeneral(0, $"{nameof(Asignatura)} no existe.");

            try
            {
                asignatura = _unitOfWork.AsignaturaRepository.Update(asignatura);
                await _unitOfWork.SaveChanges();
                return new RespuestaGeneral(1) { DatosRespuesta = asignatura };
            }
            catch (Exception ex)
            {
                return new RespuestaGeneral(0, ex.ToString());
            }
        }
    }
}
