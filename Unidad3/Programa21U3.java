import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		 Scanner sc = new Scanner (System.in);
        int i=1, nums, num, cubo;
        System.out.println("Cuantos numeros son:");
        nums = sc.nextInt();
        
    while(i<=nums)
       {
        System.out.println("Ingrese el numero:");   
        num = sc.nextInt();
        if(num>0)
        {
            cubo = num * num * num;
            System.out.println("El cubo del numero es: "+ cubo);
        }
        i++;
       }   
	}
}
