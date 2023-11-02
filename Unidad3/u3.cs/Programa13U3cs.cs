/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
       int c, num;
        
       for(c=1;c<=100;c++)
       {
        Console.WriteLine("Ingresa el numero:");
        num = Int32.Parse(Console.ReadLine());
        
        if(num>0)
        {
            Console.WriteLine("Es positivo");
        }else
            {
                Console.WriteLine("Es negativo");
            }
       }

    }
}    
