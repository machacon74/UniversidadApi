using UniversidadApi.Models;

namespace UniversidadApi.Services.GeneroService
{
    public interface IGeneroService
    {
        List<Genero> GetAllGeneros();
        Genero GetGenero(int id);
        Genero AddGenero (Genero entity);
        Genero UpdateGenero(Genero entity);
        void DeleteGenero(int id);
    }
}
