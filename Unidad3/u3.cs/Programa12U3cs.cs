/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int c, total, num;
        
        Console.WriteLine("Ingresa la cantidad de valores totales:");
        total = Int32.Parse(Console.ReadLine());
        
        for(c=1;c<=total;c++)
        {
            Console.WriteLine("Ingresa el numero:");
            num = Int32.Parse(Console.ReadLine());
            
            if(num%2==0)
            {
                Console.WriteLine("Es un numero par");
            }else
            {
                Console.WriteLine("Es un numero impar");
            }
        }
    }
}    
