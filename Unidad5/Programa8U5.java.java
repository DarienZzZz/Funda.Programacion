/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
import java.util.Scanner;
import java.util.Random;
public class Main
{
	public static void main(String[] args) {
	Scanner sc = new Scanner(System.in);
        dado();
    }
    public static void dado(){
        
        Random ran = new Random();
        
        int idk= ran.nextInt(6);
        System.out.println("La cara del dado es: "+idk);
    }
}