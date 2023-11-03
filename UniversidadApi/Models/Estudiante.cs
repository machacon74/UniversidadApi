namespace UniversidadApi.Models
{
    public class Estudiante : BaseEntity<int>
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public short IdGenero { get; set; }
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
