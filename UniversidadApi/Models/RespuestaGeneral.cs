namespace UniversidadApi.Models
{
    public class RespuestaGeneral
    {
        public int Codigo { get; set; } = 0;
        public string Mensaje { get; set; } = string.Empty;

        public RespuestaGeneral(int codigo, string mensaje = "")
        {
            Codigo = codigo;
            Mensaje = mensaje;
        }
    }
}
