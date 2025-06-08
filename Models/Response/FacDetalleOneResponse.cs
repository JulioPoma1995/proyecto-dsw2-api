using System.Collections.Specialized;

namespace ProyectoApi.Models.Response
{
    public class FacDetalleOneResponse
    {
        public int DetalleID {  get; set; }
        public int FacturaID { get; set; }
        public int ProductoID {  get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario {  get; set; }
        public decimal Subtotal {  get; set; }
        public bool Estado {  get; set; }
    }
}
