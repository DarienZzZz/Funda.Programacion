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
        System.out.print("Ingrese un numero: ");
        int num = sc.nextInt();
        System.out.println(num+" "+NumPrim(num));
	}
	 public static String NumPrim(int idk){  
        int c=0;
        String prim;
        for(int i=idk; i>0; i--){
            if(idk%i==0){
                c++;
            }
        }
        if(c==2){
            prim = "Si es numero primo";
        }else{
            prim = "No es numero primo";
        }
         return prim.toString();
    }
   
}
