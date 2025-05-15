using System;

class Program
{
    static void Main(string[] args)
    {
        using var db = new AppDbContext();

        Producto nuevo = new Producto
        {
            Nombre = "Cerveza Rubia",
            Precio = 10.5
        };

        db.Productos.Add(nuevo);
        db.SaveChanges();

        Console.WriteLine("✅ Producto guardado en la base de datos");
    }
}
