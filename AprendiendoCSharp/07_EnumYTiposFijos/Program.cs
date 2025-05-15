using System;

class Program8
{
    static void Main(string[] args)
    {
        Producto bebida1 = new Producto("Cerveza rubia", 10.0, TipoProducto.CERVEZA);
        Producto bebida2 = new Producto("Cerveza negra", 9.5, TipoProducto.CERVEZA);
        Producto bebida3 = new Producto("Margarita", 16.5, TipoProducto.COCTEL);

        Console.WriteLine($"Tome su bebida {bebida1.Nombre}, cuesta {bebida1.Precio}");
        Console.WriteLine($"Estas seguro que quieres este {bebida3.Tipo}? es una {bebida3.Nombre} y cuesta ${bebida3.Precio}");

        if(bebida1.Tipo == TipoProducto.CERVEZA)
        {
            Console.WriteLine("Tome su chela senor");
        }

        double subtotal = bebida1.CalcularSubtotal(3) + bebida2.CalcularSubtotal(2);
        Console.WriteLine($"Su precio total es ${subtotal}");
    }
}

public enum TipoProducto
{
    CERVEZA,
    COCTEL,
    AGUA,
    REFRESCO
}

// Clase Producto con enum
public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public TipoProducto Tipo { get; set; }

    public Producto(string nombre, double precio, TipoProducto tipo)
    {
        Nombre = nombre;
        Precio = precio;
        Tipo = tipo;
    }
    public double CalcularSubtotal(int cantidad)
    {
        return Precio * cantidad;
    }
}