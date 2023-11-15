using System;

namespace Pro
{
    internal class Pro
    {
        static void Main(string[] args)
        {
            double[] cals = new double[10] {100, 70, 72, 69, 80, 95, 100, 75, 82, 90 };
            double prom=0, suma=0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa la calificacion:");
                cals[i] = Convert.ToDouble(Console.ReadLine());
                
                suma = suma + cals[i];
                prom = suma/10;
            }
            Console.WriteLine("Tu premedio final es de: " + prom);
        }
    }
}