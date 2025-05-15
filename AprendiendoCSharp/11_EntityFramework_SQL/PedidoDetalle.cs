public class PedidoDetalle
{
    public int Id {get; set;}

    public int PedidoId {get; set;}
    public Pedido Pedido {get; set;}

    public int ProductoId {get; set;}
    public Producto Producto {get; set;}

    public int Cantidad {get; set;}

    public double Subtotal => Producto?.Precio * Cantidad ?? 0;
}