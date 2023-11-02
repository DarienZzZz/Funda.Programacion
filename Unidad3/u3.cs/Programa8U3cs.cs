/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int n1, n2;
        Console.WriteLine("Ingrese el primer numero: ");
        n1=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        n2=Int32.Parse(Console.ReadLine());
        
        if(n1==n2){
            Console.WriteLine("Los dos números son iguales");
        }else if(n1>n2){
            Console.WriteLine(n1+" es mayor que "+n2);
        }else{
            Console.WriteLine(n2+" es mayor que "+n1);
        }
    }
}    
