using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Entity.Models
{
    public class Calificacion : BaseEntity<int>
    {
        public int IdEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        [Range(1, 3)]
        public short Corte { get; set; }
        [Range(0, 5)]
        [Precision(3, 2)]
        public decimal Nota { get; set; }

		public Calificacion()
		{
		}

		public Calificacion(int id, int idEstudiante, int idAsignatura, short corte, decimal nota, bool activo) : base(id, activo)
        {
            IdEstudiante = idEstudiante;
            IdAsignatura = idAsignatura;
            Corte = corte;
            Nota = nota;
        }
    }
}
