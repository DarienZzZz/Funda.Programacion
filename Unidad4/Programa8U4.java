/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
import java.util.Scanner;
public class Main
{
	public static void main(String[] args) {
	 Scanner sc = new Scanner(System.in);
     //System.out.println sc.nextInt()
	  int c = 0; 
      
      System.out.println ("Ingresa la cantidad de numeros:");
      c =  sc.nextInt();

    int[] numero = new int[c];

      
    for (int i = 0; i < c; i++)
      {
	System.out.println ("Ingresa el nuemero:");
	numero[i] =  sc.nextInt();
      }
    
      for(int i=0; i<c; i++)
      {
          if(numero[i]%2==0)
          {
    System.out.println (numero[i] + " Es Par");
          }else{
    System.out.println (numero[i] + " Es Impar");
          }
      }
}
}