using System;

namespace Pro
{
    internal class Pro
    {
        static void Main(string[] args)
        {
            int[] edades = new int[] { 17, 19, 18, 18, 17 };
            //int[] edades2 = new int[] { 17, 19, 18, 18, 18 };

            /*Console.WriteLine(edades[0]);
            Console.WriteLine(edades[1]);
            Console.WriteLine(edades[2]);
            Console.WriteLine(edades[3]);
            Console.WriteLine(edades[4]);
            for (int i = 0; i < edades length; i++) para conocer el tamaño del arreglo */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice " + i + " arreglo 1 "+ " es: " + edades[i]);

                //Console.WriteLine("Indice " + i + " arreglo 2 " + " es: " + edades2[i]);
                //Console.WriteLine();
                if(edades[i]>=18)
                {
                    Console.WriteLine("Eres mayor de edad");
                }
                else
                {
                    Console.WriteLine("Eres menor de edad");
                }

            }
        }
    }
}