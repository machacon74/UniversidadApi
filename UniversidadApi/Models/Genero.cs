namespace UniversidadApi.Models
{
    public class Genero : BaseEntity<int>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public Genero(int idGenero, string nombre, string sigla, bool activo)
        {
            Id = idGenero;
            Nombre = nombre;
            Sigla = sigla;
            Activo = activo;
        }
    }
}