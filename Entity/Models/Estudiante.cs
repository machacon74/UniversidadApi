using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Estudiante : BaseEntity<int>
    {
        [MaxLength(20)]
        public string Identificacion { get; set; }
        [MaxLength(100)]
        public string Nombres { get; set; }
        [MaxLength(100)]
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public short IdGenero { get; set; }
        [Range(1, 10)]
        public int Curso { get; set; }

        public Estudiante(int id, string identificacion, string nombres, string apellidos, int edad, short idGenero, int curso, bool activo) : base(id, activo)
        {
            Identificacion = identificacion;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            IdGenero = idGenero;
            Curso = curso;
        }
    }
}
