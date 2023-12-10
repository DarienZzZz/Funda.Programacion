/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   string idk="";
        Console.WriteLine("Ingrese una palabra: ");
        idk = Console.ReadLine();
        Console.WriteLine(idk+" tiene: "+pala(idk)+" letras en total");
    }
    public static int pala(string idk1){
        int c = idk1.Length;
        return c;
    }
}