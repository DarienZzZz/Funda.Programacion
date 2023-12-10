/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
import java.util.Scanner;
public class Main
{
	public static void main(String[] args) {
	    Scanner sc = new Scanner (System.in);
	System.out.println("Eliga el proceso a realizar:");
            System.out.println("1. Temperatura C a F");
            System.out.println("2. Temperatura F a C");
            System.out.println("3. Comvertir pulgadas a metros");
            System.out.println("4. Comvertir horas a segundos");
            int opcion= sc.nextInt();
            
            switch(opcion)
            {
                case 1:
                    
                    double c;
                    System.out.println("Ingresa la temperatura a en celcious: ");
                    c = sc.nextDouble();
                    System.out.println("Resultados: " + tempCtoF(c));
                    break;
                case 2:
                    System.out.println("Resultados: " + tempftok());
                    break;
                case 3:
                    PulToMet();
                    break;
                case 4:
                    HorToSeg();
                    break;
            }
        }
        public static double tempCtoF(double c)
        {
            double resultado = (c * 1.8) + 32;
            return resultado;
        }
        public static double tempftok()
        {
             Scanner sc = new Scanner(System.in);
            double f, res=0;
            System.out.println("Ingresa la temperatura a en farenheit: ");
            f = sc.nextDouble();
            res = (f-32)*(5/9) + 273.15;
            return res;
        }
        public static void PulToMet()
        {
             Scanner sc = new Scanner(System.in);
            double pul, res = 0;
            System.out.println("Ingresa las pulgadas: ");
            pul = sc.nextDouble();
            res = pul * 39.37;
        }
        public static void HorToSeg()
        {
             Scanner sc = new Scanner(System.in);
            double hora, res = 0;
            System.out.println("Ingresa las horas: ");
            hora = sc.nextDouble();
            res = hora * 3600;
        }
}
