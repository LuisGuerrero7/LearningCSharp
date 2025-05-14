using System;

class Program7
{
    static void Main(string[] args)
    {
        
    }
}

public class Producto 
{
    private string nombre;
    private double precio;
    public string Nombre
    {
        get {return nombre;}
        set {nombre = value;}
    }

    public double Precio
    {
        get {return precio;}
        set
        {
            if(value >= 0)
            {
                precio = value
            }
            else 
            {
                Console.WriteLine("Precio invalido. Se mantiene el anterior")
            }
        }
    }
}