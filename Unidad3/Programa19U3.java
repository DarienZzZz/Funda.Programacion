
import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		 Scanner sc = new Scanner (System.in);
        int i, cn, n=0,igual=0,may=0,men=0;

        System.out.println("Ingresa la cantidad de numeros:");
        cn = sc.nextInt();
        
    for(i=1;i<=cn;i++)
       {
        System.out.println("Ingresa el numero:");
        n = sc.nextInt();
        if (n==0)
        {
            igual++;
        }else  if (n>0)
        {
            may++;
        }else  if (n<0)
        {
            men++;
        }
       }
       System.out.println("Iguales a cero: "+ igual);
       System.out.println("mayores a cero: "+ may);
       System.out.println("menores a cero: "+ men);
	}
}
