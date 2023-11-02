/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int h,h2=40, su, ph, ex;
        Console.WriteLine("Pago por hora: ");
        ph=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Cuantas horas trabajo a la semana: ");
        h=Int32.Parse(Console.ReadLine());
              
        if(h>40){
            ex=h-40;
            ex=ex*ph*2;
            su=(h2*ph)+ex;
            Console.WriteLine("Su pago es de:  "+su);
        }else{
            su=h*ph;
            Console.WriteLine("Su pago es de:  "+su);
        }
    }
}    
