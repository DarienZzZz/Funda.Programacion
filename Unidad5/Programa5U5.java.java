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
        String idk="";
        System.out.println("Ingrese una palabra: ");
        idk = sc.nextLine();
        System.out.println(idk+" tiene: "+pala(idk)+" letras en total");
    }
    public static int pala(String idk1){
        int c = idk1.length();
        return c;
    }
   
}
