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

        public async Task<RespuestaGeneral> Add(Calificacion calificacion)
        {
            var respuesta = await ValidarNewCalificacion(calificacion);
            if (respuesta.Codigo != 1)
                return respuesta;

            calificacion = await _unitOfWork.CalificacionRepository.Add(calificacion);
            return new RespuestaGeneral(1)
            {
                DatosRespuesta = calificacion
            };
        }

        public async Task<RespuestaGeneral> GetAll()
        {
            return new RespuestaGeneral(1) { DatosRespuesta = await _unitOfWork.CalificacionRepository.GetAll().ToListAsync() };
        }

        public async Task<RespuestaGeneral> GetById(int id)
        {
            return new RespuestaGeneral(1) { DatosRespuesta = await _unitOfWork.CalificacionRepository.GetByID(id) };
        }

        public async Task<RespuestaGeneral> Update(Calificacion calificacion)
        {
            RespuestaGeneral respuesta = await ValidarOldCalificacion(calificacion);
            if (respuesta.Codigo != 1)
                return respuesta;

            calificacion = _unitOfWork.CalificacionRepository.Update(calificacion);
            respuesta.DatosRespuesta = calificacion;
            return respuesta;
        }

        #region Validaciones

        private async Task<RespuestaGeneral> ValidarNewCalificacion(Calificacion calificacion)
        {
            //Si la calificacion no existe
            if (!await _unitOfWork.CalificacionRepository.Exists(calificacion.Id))
                return new RespuestaGeneral(0, $"{nameof(Calificacion)} no existe.");

            var respuesta = await ValidarOldCalificacion(calificacion);
            if (respuesta.Codigo != 1)
                return respuesta;

            return new RespuestaGeneral(1);
        }

        private async Task<RespuestaGeneral> ValidarOldCalificacion (Calificacion calificacion)
        {
            //Se valida si el Estudiante existe en BD
            if (!await _unitOfWork.EstudianteRepository.Exists(calificacion.IdEstudiante))
                return new RespuestaGeneral(0, $"{nameof(Estudiante)} no existe.");

            //Se valida si la Asignatura existe en BD
            if (!await _unitOfWork.AsignaturaRepository.Exists(calificacion.IdAsignatura))
                return new RespuestaGeneral(0, $"{nameof(Asignatura)} no existe.");

            return new RespuestaGeneral(1);
        }

        #endregion
    }
}
