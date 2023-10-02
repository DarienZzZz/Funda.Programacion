using System;

class Metros
{
    static void Main(string[] args)
    {
        int metros, pies;

        Console.WriteLine("Ingrese los metros:");
        metros = Int32.Parse(Console.ReadLine());
        
        pies= metros * 3.281;
        Console.WriteLine("Los pies son: " + pies);
    }
}