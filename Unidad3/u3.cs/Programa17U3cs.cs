/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
       char idk;
        
        do
        {
            Console.WriteLine("Bienvenido a una sala de ejecucion");
            Console.WriteLine("Escribe n para condenar a muerte");
            idk=Char.Parse(Console.ReadLine());
        }while(idk != 'n');
    }
}    
