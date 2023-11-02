/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
    int i;
    double s=1500, a=1, ta=1,su=0;
    
    for(i=1;i<=6;i++)
       {
        a= s * 0.1;
        s= a + s;
        ta=(s*12);
        Console.WriteLine("Su sueldo durante todo el año es: " + s);
        
        Console.WriteLine("Su salario bruto en el año es: " + ta);
        
        su=su + ta;
       }
       
        Console.WriteLine("Su sueldo al cabo de 6 años: " + su);
    }
}    
