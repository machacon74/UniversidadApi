namespace UniversidadApi.Models
{
    public class Calificacion : BaseEntity<int>
    {
        public int IdEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public short Corte { get; set; }
        public decimal Nota { get; set; }

        public Calificacion(int id, int idEstudiante, int idAsignatura, short corte, decimal nota, bool activo) : base(id, activo)
        {
            IdEstudiante = idEstudiante;
            IdAsignatura = idAsignatura;
            Corte = corte;
            Nota = nota;
        }
    }
}
