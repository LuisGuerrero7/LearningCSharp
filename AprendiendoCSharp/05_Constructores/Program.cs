using System;
using System.Collections.Generic; // Para usar List<T>

class Program
{
    static void Main(string[] args)
    {
        // Crear productos usando el constructor
        Producto cerveza1 = new Producto(1, "Cerveza IPA", 12.5);
        Producto coctel1 = new Producto(2, "Mojito", 18.0);
        Producto cerveza2 = new Producto(3, "Pilsen", 8.0);

        // Lista de productos
        List<Producto> menu = new List<Producto>();
        menu.Add(cerveza1);
        menu.Add(coctel1);
        menu.Add(cerveza2);

        // Mostrar todos los productos del menú
        Console.WriteLine("🧾 Menú del Bar:");
        foreach (Producto p in menu)
        {
            Console.WriteLine($"- {p.Nombre} (S/ {p.Precio})");
        }
    }
}

// Clase Producto con constructor
public class Producto
{
    public int Id;
    public string Nombre;
    public double Precio;

    // Constructor
    public Producto(int id, string nombre, double precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }

}
