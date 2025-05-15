using System;
using System.Collections.Generic;

class Program
{
    static List<Producto> inventario = new List<Producto>();
    static int idActual = 1;

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n📋 Menú CRUD:");
            Console.WriteLine("1. Crear producto");
            Console.WriteLine("2. Ver productos");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");

            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearProducto();
                    break;
                case "2":
                    VerProductos();
                    break;
                case "3":
                    ActualizarProducto();
                    break;
                case "4":
                    EliminarProducto();
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("❌ Opción inválida");
                    break;
            }
        }
    }

    static void CrearProducto()
    {
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Precio: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Producto nuevo = new Producto(idActual, nombre, precio);
        inventario.Add(nuevo);
        idActual++;

        Console.WriteLine("✅ Producto creado con éxito");
    }

    static void VerProductos()
    {
        Console.WriteLine("\n📦 Inventario actual:");
        foreach (Producto p in inventario)
        {
            Console.WriteLine($"ID: {p.Id} | Nombre: {p.Nombre} | Precio: S/ {p.Precio}");
        }
    }

    static void ActualizarProducto()
    {
        Console.Write("ID del producto a actualizar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Producto p = inventario.Find(prod => prod.Id == id);

        if (p != null)
        {
            Console.Write("Nuevo nombre: ");
            p.Nombre = Console.ReadLine();

            Console.Write("Nuevo precio: ");
            p.Precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("✅ Producto actualizado");
        }
        else
        {
            Console.WriteLine("❌ Producto no encontrado");
        }
    }

    static void EliminarProducto()
    {
        Console.Write("ID del producto a eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Producto p = inventario.Find(prod => prod.Id == id);

        if (p != null)
        {
            inventario.Remove(p);
            Console.WriteLine("🗑️ Producto eliminado");
        }
        else
        {
            Console.WriteLine("❌ Producto no encontrado");
        }
    }
}

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(int id, string nombre, double precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }
}
