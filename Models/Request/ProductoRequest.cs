namespace ProyectoApi.Models.Request
{
    public class ProductoRequest
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public DateTime fecharegistro { get; set; }
        public int estado { get; set; }

    }
}
