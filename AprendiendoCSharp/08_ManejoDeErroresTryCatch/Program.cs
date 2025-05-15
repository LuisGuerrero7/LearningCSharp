using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el precio del producto:");

        try
        {
            string input = Console.ReadLine();
            double precio = Convert.ToDouble(input); // puede lanzar excepción

            if (precio < 0)
            {
                throw new Exception("El precio no puede ser negativo.");
            }

            Console.WriteLine($"Precio válido: S/ {precio}");
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Error: El valor ingresado no es un número.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Excepción: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("🟢 Proceso terminado.");
        }
    }
}
