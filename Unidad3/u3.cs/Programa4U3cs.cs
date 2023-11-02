/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int mes;
        Console.WriteLine("Ingresa el numero de mes:");
        mes= Int32.Parse(Console.ReadLine());
        
        switch(mes)
        {
                case 1:
                Console.WriteLine("Es Enero");
                break;
                case 2:
                Console.WriteLine("Es Febrero");
                break;
                case 3:
               Console.WriteLine("Es Marzo");
                break;
                case 4:
                Console.WriteLine("Es Abril");
                break;
                case 5:
                Console.WriteLine("Es Mayo ");
                break;
                case 6:
                Console.WriteLine("Es Junio");
                break;
                case 7:
                Console.WriteLine("Es Julio");
                break;
                case 8:
                Console.WriteLine("Es Agosto");
                break;
                case 9:
                Console.WriteLine("Es Septiembre");
                break;
                case 10:
                Console.WriteLine("Es Octubre");
                break;
                case 11:
                Console.WriteLine("Es Noviembre");
                break;
                case 12:
                Console.WriteLine("Es Diciembre");
                break;
                default: Console.WriteLine("No existe ese mes");
                break;
}
    }
}    
