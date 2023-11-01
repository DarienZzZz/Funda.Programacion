import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
	    Scanner sc = new Scanner (System.in);
	    char op;
	    int num, res=0;
	    
	    do
	    {
	    System.out.println("Ingresa un numero:");
	    num=sc.nextInt();
	    System.out.println("Ingresa el signo de la operacion:");
	    op=sc.next().charAt(0);
	    
	    if (op=='+')
	    {
	        res= num + res;
	        System.out.println("La suma es: " + res);
	    }else if(op=='-')
	    {
	        res= res - num;
	        System.out.println("La resta es: " + res);
	    }else if(op=='*')
	    {
	        res= num * res;
	        System.out.println("La multiplicacion es: " + res);
	    }else if(op=='/')
	    {
	        res= res / num;
	        System.out.println("La division es: " + res);
	    }
		
	}while(op!='q');
    }
}
