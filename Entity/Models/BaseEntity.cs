namespace Entity.Models
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public bool Activo { get; set; }

		public BaseEntity()
		{
		}

		public BaseEntity(TId id, bool activo)
        {
            Id = id;
            Activo = activo;
        }
    }
}
