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
        nacci();
    }
    public static void nacci() {
        int a=0, b=1, c=0;
        for(int i=0; i<=15; i++){
            System.out.print(a+" ");
            c=a+b;
            a=b;
            b=c;
        }
   
    }
}