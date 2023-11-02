/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
     int num, suma=0;
        
        do
        {
           Console.WriteLine("Ingresa un numero:(Ingrese 0 para terminar)"); 
           num=Int32.Parse(Console.ReadLine());
           suma = suma + num;
           Console.WriteLine("----------------->suma");
           Console.WriteLine(suma);
        }while(num!=0);
       
    }
}    
