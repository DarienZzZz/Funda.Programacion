using System;

namespace Programa5U3;

class descuento
{
    static void Main(string[] args)
    {
        double p1, p2, p3, total;

        Console.WriteLine("Ingresa el valor 1:");
        p1=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el valor 1:");
        p2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el valor 1:");
        p3 = double.Parse(Console.ReadLine());

        total = p1+ p2 + p3;

        if (total >= 1500)
        {
            total = total - (total * 0.30);
            Console.WriteLine("Tiene el 30% de descuento: " + total);
        }
        else if (total < 1500 && total >= 1000)
        {
            total = total - (total * 0.20);
            Console.WriteLine("Tiene el 20% de descuento: " + total);
        }
        else if (total <= 1000 && total >= 700)
        {
            total = total - (total * 0.30);
            Console.WriteLine("Tiene el 10% de descuento: " + total);
        }
        else
        {
            Console.WriteLine("Sin descuento"+ total);
        }
    }
}
