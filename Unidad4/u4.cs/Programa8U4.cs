/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int c = 0; 
      
      Console.WriteLine ("Ingresa la cantidad de numeros:");
      c = Convert.ToInt32 (Console.ReadLine ());

    int[] numero = new int[c];

      
    for (int i = 0; i < c; i++)
      {
	Console.WriteLine ("Ingresa el nuemero:");
	numero[i] = Convert.ToInt32 (Console.ReadLine ());
      }
    
      for(int i=0; i<c; i++)
      {
          if(numero[i]%2==0)
          {
    Console.WriteLine (numero[i] + " Es Par");
          }else{
    Console.WriteLine (numero[i] + " Es Impar");
          }
      }
      
  }
}
