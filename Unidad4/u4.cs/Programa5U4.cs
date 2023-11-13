/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int c=0;

      Console.WriteLine("Ingresa la cantidad de frutas:");
      c = Int32.Parse(Console.ReadLine());
      
      string[] fruta = new string[c] /*{"alla","aca"}*/;
      
      for(int i=0;i<c;i++)
      {
        Console.WriteLine("Ingresa la fruta:");
        fruta[i] = Console.ReadLine();
        
      }
      
      for(int j=c-1; j>=0; j--)
        {
        Console.WriteLine("Frutas al revez:" + fruta[j]);
        }
  
  }
}
