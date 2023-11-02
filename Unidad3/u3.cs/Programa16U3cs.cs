/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
       int i=20,h,p,s;
        
        while(i>=1)
        {
            Console.WriteLine("Ingresa la cantidad de horas semanales:");
            h = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el pago por hora:");
            p = Int32.Parse(Console.ReadLine());
            s= h * p;
            Console.WriteLine("Su sueldo total es: " + s);
            i--;
        }
    }
}    
