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

      Console.WriteLine("Ingresa el numero de nombres:");
      c = Int32.Parse(Console.ReadLine());

      string[] nombre = new string[c];
      string[] apelli = new string[c];

      for (int i = 0; i < c; i++)
      {
         
        Console.WriteLine("Ingresa el nombre:");
        nombre[i] = Console.ReadLine();
        Console.WriteLine("Ingresa el apellido:");
        apelli[i] = Console.ReadLine();
        
        Console.WriteLine(nombre[i] + " " + apelli[i]);
      }
    }
    }
}
