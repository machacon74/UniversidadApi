using UniversidadApi.Models;

namespace UniversidadApi.Services.AsignaturaService
{
    public class AsignaturaService : IAsignaturaService
    {
        IUnitOfWork UnitOfWork { get; }

        public AsignaturaService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public async Task<List<Asignatura>> GetAll()
        {
            return await UnitOfWork.AsignaturaRepository.GetAll().ToListAsync();
        }

        public async Task<Asignatura?> GetById(int id)
        {
            return await UnitOfWork.AsignaturaRepository.GetByID(id);
        }

        public async Task<Asignatura?> Add(Asignatura entity)
        {
            var genero = await UnitOfWork.AsignaturaRepository.Add(entity);
            await UnitOfWork.SaveChanges();
            return genero;
        }

        public async Task<Asignatura?> Update(Asignatura entity)
        {
            var genero = UnitOfWork.AsignaturaRepository.Update(entity);
            await UnitOfWork.SaveChanges();
            return genero;
        }
    }
}
