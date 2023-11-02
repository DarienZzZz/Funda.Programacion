/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main(){
     char op;
	    int num, res=0;
	    
	    do
	    {
	    Console.WriteLine("Ingresa un numero:");
	    num=Int32.Parse(Console.ReadLine());
	    Console.WriteLine("Ingresa el signo de la operacion:");
	    op=char.Parse(Console.ReadLine());
	    
	    if (op=='+')
	    {
	        res= num + res;
	        Console.WriteLine("La suma es: " + res);
	    }else if(op=='-')
	    {
	        res= res - num;
	        Console.WriteLine("La resta es: " + res);
	    }else if(op=='*')
	    {
	        res= num * res;
	        Console.WriteLine("La multiplicacion es: " + res);
	    }else if(op=='/')
	    {
	        res= res / num;
	        Console.WriteLine("La division es: " + res);
	    }
		
	}while(op!='q');
    }
}    
