using Entity.Models;
using UniversidadApi.Data;

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
            try
            {
                var respuesta = await ValidarCalificacion(calificacion);
                if (respuesta.Codigo != 1)
                    return respuesta;

                calificacion = await _unitOfWork.CalificacionRepository.Add(calificacion);
                await _unitOfWork.SaveChanges();
                return new RespuestaGeneral<Calificacion>()
                {
                    Codigo = 1,
                    DatosRespuesta = calificacion
                };
            }
            catch (Exception ex)
            {
                return new RespuestaGeneral<Calificacion>(0, ex.ToString());
            }
        }

        public async Task<RespuestaGeneral> GetAll()
        {
            return new RespuestaGeneral<List<Calificacion>>() 
            { 
                Codigo = 1,
                DatosRespuesta = await _unitOfWork.CalificacionRepository.GetAll().ToListAsync() 
            };
        }

        public async Task<RespuestaGeneral> GetById(int id)
        {
            return new RespuestaGeneral<Calificacion>() 
            {
                Codigo = 1,
                DatosRespuesta = await _unitOfWork.CalificacionRepository.GetByID(id) 
            };
        }

        public async Task<RespuestaGeneral> Update(Calificacion calificacion)
        {
            var respuesta = await ValidarOldCalificacion(calificacion);
            if (respuesta.Codigo != 1)
                return respuesta;

            calificacion = _unitOfWork.CalificacionRepository.Update(calificacion);
            await _unitOfWork.SaveChanges();
            respuesta = new RespuestaGeneral<Calificacion>()
            {
                Codigo = 1,
                DatosRespuesta = calificacion
            };
            return respuesta;
        }

        #region Validaciones

        private async Task<RespuestaGeneral> ValidarOldCalificacion(Calificacion calificacion)
        {
            //Si la calificacion no existe
            if (!await _unitOfWork.CalificacionRepository.Exists(calificacion.Id))
                return new RespuestaGeneral(0, $"{nameof(Calificacion)} no existe.");

            var respuesta = await ValidarCalificacion(calificacion);
            if (respuesta.Codigo != 1)
                return respuesta;

            return new RespuestaGeneral(1);
        }

        private async Task<RespuestaGeneral> ValidarCalificacion(Calificacion calificacion)
        {
            //Se valida si el Estudiante existe en BD
            if (!await _unitOfWork.EstudianteRepository.Exists(calificacion.IdEstudiante))
                return new RespuestaGeneral(0, $"{nameof(Estudiante)} no existe.");

            //Se valida si la Asignatura existe en BD
            if (!await _unitOfWork.AsignaturaRepository.Exists(calificacion.IdAsignatura))
                return new RespuestaGeneral(0, $"{nameof(Asignatura)} no existe.");

            if (await _unitOfWork.CalificacionRepository.GetAll().AnyAsync(
                c => c.IdAsignatura.Equals(calificacion.IdAsignatura)
                && c.IdEstudiante.Equals(calificacion.IdEstudiante)
                && c.Corte == calificacion.Corte
                && c.Id != calificacion.Id))
                return new RespuestaGeneral(0, $"{nameof(Estudiante)} ya cuenta con {nameof(Calificacion)} para esta {nameof(Asignatura)} y {nameof(Calificacion.Corte)}.");

            return new RespuestaGeneral(1);
        }

        #endregion
    }
}
