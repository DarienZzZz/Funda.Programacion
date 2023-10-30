import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
		 Scanner sc = new Scanner (System.in);
        int i=1, dia=1,ano=1, idk=3;
        
    while(i<=365)
       {
        System.out.println("Su ahorro es de: "+ idk);   
        idk= idk * 3;
        ano=idk+ano;
        i++;
       }
        System.out.println("Su ahorro anual es: "+ ano);   
	}
}
