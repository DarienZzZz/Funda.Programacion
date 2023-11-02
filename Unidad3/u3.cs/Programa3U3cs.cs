/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
     int dia;
        
        Console.WriteLine("Ingresa el dia:");
        dia=Int32.Parse(Console.ReadLine());
        
        switch(dia)
        {
                case 1:
                Console.WriteLine("Es lunes");
                break;
                case 2:
                Console.WriteLine("Es martes");
                break;
                case 3:
                Console.WriteLine("Es miercoles");
                break;
                case 4:
                Console.WriteLine("Es jueves");
                break;
                case 5:
                Console.WriteLine("Es viernes");
                break;
                case 6:
                Console.WriteLine("Es sabado");
                break;
                case 7:
                Console.WriteLine("Es domingo");
                break;
                
                default: Console.WriteLine("No existe ese dia");
                break;
        }
    }
}    
