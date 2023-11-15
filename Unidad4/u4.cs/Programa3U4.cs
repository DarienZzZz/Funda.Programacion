using System;

namespace Pro
{
    internal class Pro
    {
        static void Main(string[] args)
        {
            int prom = 0, suma = 0, t = 0,f=0;
            double k = 0;

            Console.WriteLine("Ingresa la cantidad de temperaturas:");
            t = Convert.ToInt32(Console.ReadLine());
            int[] tem = new int[t];

            for (int i = 0; i<t; i++)
            {
                Console.WriteLine("Ingresa la temperatura:");
                tem[i] = Convert.ToInt32(Console.ReadLine());

                k = (tem[i] + 273.15);
                Console.WriteLine("La temperatura en Kelvin es de: " + k);
                f = (tem[i] * 9 / 5) + 32;
                Console.WriteLine("La temperatura en Farenheit es de: " + f);
            }
        }
    }
 }

