using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Asignatura : BaseEntity<int>
    {
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(1, 10)]
        public short Creditos { get; set; }

		public Asignatura()
		{
		}

		public Asignatura(int id, string nombre, short creditos, bool activo) : base(id, activo)
        {
            Nombre = nombre;
            Creditos = creditos;
        }
    }
}
