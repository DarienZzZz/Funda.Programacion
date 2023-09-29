using System;

class Traingulo
{
    static void Main(string[] args)
    {
        int peri, area, h, ba, lado;

        Console.WriteLine("Ingrese la altura:");
        h = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la base:");
        ba = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el lado:");
        lado = Int32.Parse(Console.ReadLine());

        area = (ba * h) / 2;
        peri = lado * 3;
        Console.WriteLine("El area es: " + area);
        Console.WriteLine("El perimetro es: " + peri);
    }
}