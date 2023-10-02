using System;

namespace Promedios;

class promedio
{
    static void Main(string[] args)
    {
        int y, a, res;
        Console.WriteLine("Ingresa Y:");
        y = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa A:");
        a = Int32.Parse(Console.ReadLine());

        res= y + a + 3;
        Console.WriteLine("El resultado de y + a + 3 es:" + res);
    }
}
