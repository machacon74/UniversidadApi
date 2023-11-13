namespace Entity.Models
{
    public class RespuestaGeneral
    {
        public int Codigo { get; set; } = 0;
        public string Mensaje { get; set; } = string.Empty;
        public object? DatosRespuesta { get; set; }

        public RespuestaGeneral()
        {
        }

        public RespuestaGeneral(int codigo, string mensaje = "", object? datosRespuesta = null)
        {
            Codigo = codigo;
            Mensaje = mensaje;
            DatosRespuesta = datosRespuesta;
        }
    }
}
