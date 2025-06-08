namespace ProyectoApi.Models.Response
{
    public class FacDetalleResponse
    {
        public int id_factura { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string? MetodoPago { get; set; }
        public int EstadoFactura { get; set; }
        public int id_cliente { get; set; }
        public string? NombreCliente {  get; set; }
        public string? Apellido {  get; set; }
        public string? DocumentoIdentidad {  get; set; }
        public int DetalleID {  get; set; }
        public int ProductoID {  get; set; }
        public int Cantidad {  get; set; }
        public decimal PrecioUnitario {  get; set; }
        public decimal Subtotal {  get; set; }
        public int EstadoDetalle {  get; set; }

        public int id_producto {  get; set; }
        public string? NombreProducto {  get; set; }
        public decimal PrecioProducto {  get; set; }

    }
}
