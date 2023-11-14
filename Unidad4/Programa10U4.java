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
    double prom=0, suma =0, idk;

    System.out.println("Ingresa el numero de paises:");
    c = sc.nextInt();

    String[] pais = new String[c];

    for (int i = 0; i < c; i++)
    {

      System.out.println("Ingresa el pais:");
      pais [i] = sc.next();
      
      suma = pais[i].length + suma;
      prom = suma / c;
    }
    System.out.println("El promedio de las longitudes de los paises es:" + prom);
        }
}

