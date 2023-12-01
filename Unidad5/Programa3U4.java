/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package programa3u4;
import java.util.Scanner;
import java.lang.Math;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa3U4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc= new Scanner (System.in);
        System.out.print("Ingresa x: ");
        double x = sc.nextDouble();
        System.out.print("Ingresa y: ");
        double y = sc.nextDouble();
        
        System.out.println("Resultados 1ra ecuacion: " + ec1(x,y));
        System.out.println("Resultados 1ra ecuacion: " + ec2(x,y));
        
    }
    public static double ec1(double x, double y){
        double r;
       r= Math.pow(x,2)+(2*Math.pow(y,4));
        return r;
        
    }
    public static double ec2(double x, double y){
        double r;
       r= Math.sqrt(Math.pow(x,4)+ (5*y));
        return r;
        
    }
    
}
