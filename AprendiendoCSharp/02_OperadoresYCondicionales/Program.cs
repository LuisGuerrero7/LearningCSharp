// See https://aka.ms/new-console-template for more information
using System;

class Program2
{
    static void Main(string[] args){
        int edad = 20;
        bool tieneEntrada = true;

        if (edad >= 18){
            Console.WriteLine("Puedes entrar al bar");
        }
        else {
            Console.WriteLine("No puedes entrar al bar");
        }

        if (edad >= 18 && tieneEntrada)
        {
            Console.WriteLine("Puedes entrar sin problemas");
        }

        string mensaje = (edad<21) ? "No puedes tomar en la sede de usa" : "Puedes tomar en la sede de usa";

        Console.WriteLine(mensaje);

        int cerveza = 15;
        int cocktail = 20;
        int totalBebidas = cerveza*2 + cocktail*3;

        Console.WriteLine("Total de bebidas: " + totalBebidas);  
    }
}