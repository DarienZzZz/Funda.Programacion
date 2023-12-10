/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   Console.WriteLine("Ingrese el precio del producto: ");
        double idk = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de productos: ");
        int idk1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El subtotal del producto es: "+sub(idk, idk1));
        Console.WriteLine("El IVA del producto es: "+iva(idk));
        Console.WriteLine("El total a pagar es: "+total(idk,idk1));
    }
    
    public static double iva(double a){
        double iva=0.16;
        double res = a*iva;
        return res;
    }
    
    public static double sub(double a, int b){
        double res = a*b;
        return res;
    }
    
    public static double total(double b, double c){
        double iva=0.16;
        double res= (b*c)+((b*c)*iva);
        return res;
    }
}