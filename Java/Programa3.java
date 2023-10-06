/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int num1,num2,num3,num4,num5,num6, prom;
        
        System.out.print("Escribe la calificacion 1:");
        num1 = sc.nextInt(); //nextInt(); Para comvertir datos a entero
        System.out.print("Escribe la calificacion 2:");
        num2 = sc.nextInt();
        System.out.print("Escribe la calificacion 3:");
        num3 = sc.nextInt(); //nextInt(); Para comvertir datos a entero
        System.out.print("Escribe la calificacion 4:");
        num4 = sc.nextInt();
        System.out.print("Escribe la calificacion 5:");
        num5 = sc.nextInt(); //nextInt(); Para comvertir datos a entero
        System.out.print("Escribe la calificacion 6:");
        num6 = sc.nextInt();
        
        prom = (num1 + num2 + num3 + num4 + num5 + num6)/6;       
        System.out.println("Resultados: " + prom);        
    }
}
