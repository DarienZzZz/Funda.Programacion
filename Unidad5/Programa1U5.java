/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

public class Main
{
	public static void main(String[] args) {
		System.out.println(suma(7,8));
        System.out.println(res(7,8));
        System.out.println(mul(7,8));
        System.out.println(div(7,8));
    }
    //Metodo
   public static int res(int a, int b)
   {
       int r=a-b;
       return r;
   }
   public static int mul(int a, int b)
   {
       int r=a*b;
       return r;
   }
   public static int suma(int a, int b)
   {
       int r=a+b;
       return r;
   }
   public static double div(double a, double b)
   {
       double r=a/b;
       return r;
   }
}
