using System;

class Program4
{
    static void Main(string[] args){
        Saludar("Luis");
        int suma = Sumar(30,40);
        Console.WriteLine("La suma es " + suma);

        MostrarPrecio("cerveza", 15);
    }

    static void Saludar(string nombre){
        Console.WriteLine("Hola " + nombre);
    }

    static int Sumar(int a, int b){
        return a + b;
    }

    static void MostrarPrecio(string producto, double precio){
        Console.WriteLine("El " + producto + " cuesta $" + precio  );
    }
}