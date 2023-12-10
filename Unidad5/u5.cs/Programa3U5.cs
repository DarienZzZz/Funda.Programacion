/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   Console.WriteLine("Ingresa x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Resultados 1ra ecuacion: " + ec1(x,y));
        Console.WriteLine("Resultados 1ra ecuacion: " + ec2(x,y));
        
    }
    public static double ec1(double x, double y){
        double r;
       r= Math.Pow(x,2)+(2*Math.Pow(y,4));
        return r;
        
    }
    public static double ec2(double x, double y){
        double r;
       r= Math.Sqrt(Math.Pow(x,4)+ (5*y));
        return r;
        
    }
}