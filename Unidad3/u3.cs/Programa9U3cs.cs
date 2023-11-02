/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      int h, costo, a=10, b=12, c=15;
       Console.WriteLine("Ingrese las horas que estuvo en el estacionamiento: ");
        h=Int32.Parse(Console.ReadLine());
        
        if(h<=2){
            costo=h*5;
            Console.WriteLine("El costo es de: "+costo);
        }else if(h>2&&h<=5){
            costo=(h*4)+a;
            Console.WriteLine("El costo es de: "+costo);
        }else if(h>5&&h<10){
            costo=(h*3)+a+b;
            Console.WriteLine("El costo es de: "+costo);
        }else{
            costo=(h*2)+a+b+c;
            Console.WriteLine("El costo es de: "+costo);
        }
    }
}    
