/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int num1,num2,num3,num4,num5,num6, prom;
        
        Console.WriteLine("Escribe la calificacion 1:");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe la calificacion 2:");
        num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe la calificacion 3:");
        num3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe la calificacion 4:");
        num4 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe la calificacion 5:");
        num5 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe la calificacion 6:");
        num6 = Int32.Parse(Console.ReadLine());
        
        prom = (num1 + num2 + num3 + num4 + num5 + num6)/6;       
        
        if(prom>=6)
        {
            Console.WriteLine("Aprobado: " + prom);
        }else
        {
            Console.WriteLine("Reprobado: " + prom);
        }
    }
}    
