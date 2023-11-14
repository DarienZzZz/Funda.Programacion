/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

namespace pro
{
    internal class Pro
    {
        static void Main(string[]args)
        {
            
    int c = 0;
    double prom=0, suma =0;

    Console.WriteLine("Ingresa el numero de paises:");
    c = Int32.Parse(Console.ReadLine());

    string[] pais = new string[c];

    for (int i = 0; i < c; i++)
    {

      Console.WriteLine("Ingresa el pais:");
      pais [i] = Console.ReadLine();

      suma = suma+pais[i].Length;
      prom = suma / c;
    }
    Console. WriteLine("El promedio de las longitudes de los paises es:" + prom);
        }
    }
}
