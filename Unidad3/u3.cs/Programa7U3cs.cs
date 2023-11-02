/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int temp;
        Console.WriteLine("Temperatura actual: ");
        temp=Int32.Parse(Console.ReadLine());
        
        if(temp>=27){
            Console.WriteLine("Hace calor");
        }else if(temp>=20&&temp<27){
            Console.WriteLine("Clima agradable");
        }else{
            Console.WriteLine("Hace frio");
        }
    }
}    
