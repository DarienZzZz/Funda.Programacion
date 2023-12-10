/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine(suma(7,8));
        Console.WriteLine(res(7,8));
        Console.WriteLine(mul(7,8));
        Console.WriteLine(div(7,8));
    }
    //Metodo
   public static int res(int a, int b)
   {
       int r=a-b;
       return r;
   }
   public static int mul(int a, int b)
   {
       int r=a*b;
       return r;
   }
   public static int suma(int a, int b)
   {
       int r=a+b;
       return r;
   }
   public static double div(double a, double b)
   {
       double r=a/b;
       return r;
   }
}