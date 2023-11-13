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
    double media=0,mediana=0,suma=0, idk=0;
    
      
      Console.WriteLine ("Ingresa la cantidad de numeros:");
      c = Convert.ToInt32 (Console.ReadLine ());

    double[] numero = new double[c];

      
    for (int i = 0; i < c; i++)
      {
	Console.WriteLine ("Ingresa el nuemero:");
	numero[i] = Convert.ToDouble (Console.ReadLine ());
	suma += numero[i];
      }
      media=suma/c;
      
      
    //metodo burbuja
	for (int i = 0; i < c-1; i++)
	  {
	    if (numero[i] > numero[i+1])
	      {
		idk = numero[i]; 
		numero[i]=numero[i+1]; 
		numero[i+1]=idk;
	      }
	  }
      
      
      if(c%2==0)
      {
          mediana= (numero[c/2] + numero[c-1])/2;
      }else{
          mediana= numero[c/2];
      }
      
    Console.WriteLine ("Mediana: " + mediana);
    Console.WriteLine ("Media: " + media);
  }
}