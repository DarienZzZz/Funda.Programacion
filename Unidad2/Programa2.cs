
using System;
namespace Programa2;

 internal class suma
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int suma;

        Console.WriteLine("Ingrese el Numero 1:");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Numero 2:");
        num2 = Int32.Parse (Console.ReadLine());

        suma= num1 + num2;
        Console.WriteLine("La suma es:" + suma);

    }
}