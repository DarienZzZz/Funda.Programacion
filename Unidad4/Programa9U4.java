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
	 int c;

      System.out.println("Ingresa el numero de nombres:");
      c = sc.nextInt();

      String[] nombre = new String[c];
      String[] apelli = new String[c];

      for (int i = 0; i < c; i++)
      {
        System.out.println("Ingresa el nombre:");
        nombre[i] = sc.next();
        
        System.out.println("Ingresa el apellido:");
        apelli[i] = sc.next();
        
        System.out.println(nombre[i] + " " + apelli[i]);
	}
}
}