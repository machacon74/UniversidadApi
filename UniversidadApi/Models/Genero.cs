namespace UniversidadApi.Models
{
    public class Genero : BaseEntity<short>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public Genero(short id, string nombre, string sigla, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Sigla = sigla;
            this.Activo = activo;
        }
    }
}