/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
     int num;
        
        do
        { 
        Console.WriteLine("Ingrese un numero:(Ingrese numero negativo para acabar)");
        num=Int32.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Es par");
            }else
            {
                Console.WriteLine("Es impar");    
            }
        }while(num>0);
    }
}    
