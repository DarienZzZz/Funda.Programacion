using System;

class Iva
{
    static void Main(string[] args)
    {
        int art1, art2, art3, suma, total;
        double iva;

        Console.WriteLine("Ingrese el valor del articulo 1:");
        art1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del articulo 2:");
        art2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del articulo 3:");
        art3 = Int32.Parse(Console.ReadLine());

        total= art1 + art2 + art3;
        suma= (art1 + art2 + art3) * 0.16;
        iva=total - suma;
        Console.WriteLine("El IVA total es : " + suma);
        Console.WriteLine("El IVA sub es: " + iva);
    }
}