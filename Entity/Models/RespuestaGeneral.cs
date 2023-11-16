namespace Entity.Models
{
	public class RespuestaGeneral
	{
		public int Codigo { get; set; } = 0;
		public string Mensaje { get; set; } = string.Empty;

		public RespuestaGeneral()
		{
		}

		public RespuestaGeneral(int codigo, string mensaje= "")
		{
			Codigo = codigo;
			Mensaje = mensaje;
		}
	}

	public class RespuestaGeneral<T> : RespuestaGeneral
    {
        public T? DatosRespuesta { get; set; }

        public RespuestaGeneral()
        {
        }

        public RespuestaGeneral(int codigo, string mensaje, T? datosRespuesta = default) : base(codigo, mensaje)
		{
            DatosRespuesta = datosRespuesta;
        }
    }
}
