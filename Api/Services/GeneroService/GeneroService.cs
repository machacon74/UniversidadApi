using Entity.Models;
using UniversidadApi.Data;

namespace UniversidadApi.Services.GeneroService
{
    public class GeneroService : IGeneroService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GeneroService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RespuestaGeneral> GetAll()
        {
            return new RespuestaGeneral<List<Genero>>()
            {
                Codigo = 1,
                DatosRespuesta = await _unitOfWork.GeneroRepository.GetAll().ToListAsync()
            };
        }

        public async Task<RespuestaGeneral> GetById(short id)
        {
            return new RespuestaGeneral<Genero>()
            {
                Codigo = 1,
                DatosRespuesta = await _unitOfWork.GeneroRepository.GetByID(id)
            };
        }

        public async Task<RespuestaGeneral> Add(Genero genero)
        {
            genero = await _unitOfWork.GeneroRepository.Add(genero);
            await _unitOfWork.SaveChanges();
            return new RespuestaGeneral<Genero>()
            {
                Codigo = 1,
                DatosRespuesta = genero
            };
        }

        public async Task<RespuestaGeneral> Update(Genero genero)
        {
            //Si el genero no existe
            if (!await _unitOfWork.GeneroRepository.Exists(genero.Id))
                return new RespuestaGeneral(0, $"{nameof(Genero)} no existe.");

            genero = _unitOfWork.GeneroRepository.Update(genero);
            await _unitOfWork.SaveChanges();
            return new RespuestaGeneral<Genero>()
            {
                Codigo = 1,
                DatosRespuesta = genero
            };
        }
    }
}
