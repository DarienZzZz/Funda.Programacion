/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
     int i=1, nums, num, cubo;
        Console.WriteLine("Cuantos numeros son:");
        nums = Int32.Parse(Console.ReadLine());
        
    while(i<=nums)
       {
        Console.WriteLine("Ingrese el numero:");   
        num = Int32.Parse(Console.ReadLine());
        if(num>0)
        {
            cubo = num * num * num;
            Console.WriteLine("El cubo del numero es: "+ cubo);
        }
        i++;
      }
       
    }
}    
