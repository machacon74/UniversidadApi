namespace UniversidadApi.Models
{
    public class Asignatura : BaseEntity<int>
    {
        public string Nombre { get; set; }
        public short Creditos { get; set; }

        public Asignatura(int id, string nombre, short creditos, bool activo) : base(id, activo)
        {
            this.Nombre = nombre;
            this.Creditos = creditos;
        }
    }
}
