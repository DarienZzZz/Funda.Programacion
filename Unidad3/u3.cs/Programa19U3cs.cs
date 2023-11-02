/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
     int i, cn, n=0,igual=0,may=0,men=0;

        Console.WriteLine("Ingresa la cantidad de numeros:");
        cn = Int32.Parse(Console.ReadLine());
        
    for(i=1;i<=cn;i++)
       {
        Console.WriteLine("Ingresa el numero:");
        n = Int32.Parse(Console.ReadLine());
        if (n==0)
        {
            igual++;
        }else  if (n>0)
        {
            may++;
        }else  if (n<0)
        {
            men++;
        }
       }
       Console.WriteLine("Iguales a cero: "+ igual);
       Console.WriteLine("mayores a cero: "+ may);
       Console.WriteLine("menores a cero: "+ men);
    }
}    
