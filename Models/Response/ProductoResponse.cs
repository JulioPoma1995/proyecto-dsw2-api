namespace ProyectoApi.Models.Response
{
    public class ProductoResponse
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public DateTime fecharegistro { get; set; }
        public int estado { get; set; }
    }
}
