using UniversidadApi.Models;

namespace UniversidadApi.Services.GeneroService
{
    public interface IGeneroService
    {
        Task<List<Genero>> GetAllGeneros();
        Task<Genero?> GetGenero(short id);
        Task<Genero?> AddGenero (Genero entity);
        Task<Genero?> UpdateGenero(Genero entity);
    }
}
