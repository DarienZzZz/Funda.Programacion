using System;

class Traingulo
{
    static void Main(string[] args)
    {
        int edad;

        Console.WriteLine("Ingrese la altura:");
        edad = Int32.Parse(Console.ReadLine());
       
        if (edad<=18)
    {
        Console.WriteLine("Eres Menor de edad tilin");
    }
    else
    {
        Console.WriteLine("Eres Mayor de edad");
    }
        
        
    }
}