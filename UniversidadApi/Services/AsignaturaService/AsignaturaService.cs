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
            return await UnitOfWork.asignaturas.GetAll().ToListAsync();
        }

        public async Task<Genero?> GetById(short id)
        {
            return await UnitOfWork.GeneroRepository.GetByID(id);
        }

        public async Task<Genero?> Add(Genero entity)
        {
            var genero = await UnitOfWork.GeneroRepository.Add(entity);
            await UnitOfWork.SaveChanges();
            return genero;
        }

        public async Task<Genero?> Update(Genero entity)
        {
            var genero = UnitOfWork.GeneroRepository.Update(entity);
            await UnitOfWork.SaveChanges();
            return genero;
        }
    }
}
