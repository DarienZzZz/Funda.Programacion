/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa8;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa8 {

    public static void main(String[] args) {
         Scanner sc= new Scanner(System.in);
         
         double p1,p2,p3, sub, total, ivaT;
         final double iva=0.16;
         
         System.out.print("Ingrese valor 1:");
         p1 = sc.nextDouble();//Comvertir de cadena a decimal
         System.out.print("Ingrese valor 2:");
         p2 = sc.nextDouble();
         System.out.print("Ingrese valor 3:");
         p3 = sc.nextDouble();
         
         total = p1 + p2 + p3;
         ivaT = total * iva;
         sub = total - ivaT;
         System.out.println("El total es: "+ total);
         System.out.println("El subtotal es: "+ sub);
         System.out.println("El iva es: "+ ivaT);
    }
}
