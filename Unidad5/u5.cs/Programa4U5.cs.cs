/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   Console.WriteLine("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num+" "+NumPrim(num));
	}
	 public static string NumPrim(int idk){  
        int c=0;
        String prim;
        for(int i=idk; i>0; i--){
            if(idk%i==0){
                c++;
            }
        }
        if(c==2){
            prim = "Si es numero primo";
        }else{
            prim = "No es numero primo";
        }
         return prim;
  }
}