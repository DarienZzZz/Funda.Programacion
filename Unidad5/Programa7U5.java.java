/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
	Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese el precio del producto: ");
        double idk = sc.nextDouble();
        System.out.print("Ingrese la cantidad de productos: ");
        int idk1= sc.nextInt();
        System.out.println("El subtotal del producto es: "+sub(idk, idk1));
        System.out.println("El IVA del producto es: "+iva(idk));
        System.out.println("El total a pagar es: "+total(idk,idk1));
    }
    
    public static double iva(double a){
        double iva=0.16;
        double res = a*iva;
        return res;
    }
    
    public static double sub(double a, int b){
        double res = a*b;
        return res;
    }
    
    public static double total(double b, double c){
        double iva=0.16;
        double res= (b*c)+((b*c)*iva);
        return res;
    }
}