using System;

class Program
{
    static void Main(string[] args)
    {
        // Creamos una instancia (objeto) de la clase Producto
        Producto cerveza = new Producto();
        cerveza.Id = 1;
        cerveza.Nombre = "Cerveza Artesanal";
        cerveza.Precio = 12.5;

        Console.WriteLine("Producto: " + cerveza.Nombre);
        Console.WriteLine("Precio: S/ " + cerveza.Precio);
    }
}

// Definimos nuestra propia clase fuera del Main
public class Producto
{
    public int Id;
    public string Nombre;
    public double Precio;
}
