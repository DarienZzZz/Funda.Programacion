using System;

class Hexa
{
    static void Main(string[] args)
    {
        int peri, apo, area;

        Console.WriteLine("Ingrese el perimetro:");
        peri = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el apotema:");
        apo = Int32.Parse(Console.ReadLine());

        area= (pero * apo) / 2;
        Console.WriteLine("El area es: " + area);
    }
}