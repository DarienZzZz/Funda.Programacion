/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
  static void Main ()
  {
      //variables
    int c = 0, idk = 0;
      //Indicar el limite del arreglo
      Console.WriteLine ("Ingresa la cantidad de numeros:");
      c = Int32.Parse (Console.ReadLine ());

    int[] numero = new int[c];
    int[] numero2 = new int[c];

      //For para llenar los arreglos
    for (int i = 0; i < c; i++)
      {
	Console.WriteLine ("Ingresa el nuemero:");
	numero[i] = Convert.ToInt32 (Console.ReadLine ());
	numero2[i] = numero[i];
      }
      //Inicio del metodo burbuja para ordenar los arreglos
    for (int j = 0; j < c; j++)
      {
	for (int i = 0; i < c; i++)
	  {
	    if (numero[i] < numero2[j])
	      {
		idk = numero[j]; //Almacenamos el valor del primer arreglo para no perderlo
		numero[j]=numero2[i]; //Limpiamos de nuevo el arreglo
		numero2[i]=idk; //Y almacenas el valor previamente guardado para poder imprimir
	      }
	  }
      }
      for(int i=0; i < c; i++)
      {
    Console.WriteLine ("De menor a Mayor: " + numero[i]);
      }
  }
}
