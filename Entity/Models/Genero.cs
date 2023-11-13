namespace Entity.Models
{
    public class Genero : BaseEntity<short>
    {
        public string Nombre { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;

        public Genero(short id, string nombre, string sigla, bool activo) : base(id, activo)
        {
            Nombre = nombre;
            Sigla = sigla;
        }
    }
}