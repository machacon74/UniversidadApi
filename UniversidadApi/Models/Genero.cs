namespace UniversidadApi.Models
{
    public class Genero
    {
        public int IdGenero { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;

        public Genero(int idGenero, string nombre, string sigla, bool activo)
        {
            IdGenero = idGenero;
            Nombre = nombre;
            Sigla = sigla;
            Activo = activo;
        }
    }
}