/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   nacci();
    }
    public static void nacci() {
        int a=0, b=1, c=0;
        for(int i=0; i<=15; i++){
            Console.Write(a+" ");
            c=a+b;
            a=b;
            b=c;
        }
   
    }
}