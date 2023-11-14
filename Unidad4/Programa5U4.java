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
	 int c=0;

      System.out.println("Ingresa la cantidad de frutas:");
      c = sc.nextInt();
      
      String[] fruta = new String[c] /*{"alla","aca"}*/;
      
      for(int i=0;i<c;i++)
      {
        System.out.println("Ingresa la fruta:");
        fruta[i] = sc.next();
        
      }
      
      for(int j=c-1; j>=0; j--)
        {
        System.out.println("Frutas al revez:" + fruta[j]);
        }
}
}