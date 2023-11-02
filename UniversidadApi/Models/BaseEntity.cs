namespace UniversidadApi.Models
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public bool Activo { get; set; }
    }
}
