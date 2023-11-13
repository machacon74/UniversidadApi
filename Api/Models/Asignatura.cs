using System.ComponentModel.DataAnnotations;

namespace UniversidadApi.Models
{
    public class Asignatura : BaseEntity<int>
    {
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(1, 10)]
        public short Creditos { get; set; }

        public Asignatura(int id, string nombre, short creditos, bool activo) : base(id, activo)
        {
            this.Nombre = nombre;
            this.Creditos = creditos;
        }
    }
}
