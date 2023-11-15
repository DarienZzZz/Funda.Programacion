using System;

namespace Pro
{
    internal class Pro
    {
        static void Main(string[] args)
        {
            int neg = 0, c;   

            Console.WriteLine("Ingresa la cantidad de numeros:");
            c = Convert.ToInt32(Console.ReadLine());
            int[] n = new int[c];

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Ingresa el numero:");
                n[i] = Convert.ToInt32(Console.ReadLine());

                if (n[i]<0)
                {
                    neg++;
                }
            }
            Console.WriteLine("Cantidad de numero negativos: " + neg);

        }
    }
}

