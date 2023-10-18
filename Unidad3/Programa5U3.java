/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa5u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa5U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
       double p1,p2,p3,total;
        
        System.out.println("Ingresa el valor 1:");
        p1 = sc.nextDouble();
        System.out.println("Ingresa el valor 2:");
        p2 = sc.nextDouble();
        System.out.println("Ingresa el valor 3:");
        p3 = sc.nextDouble();
        
        total= p1+p2+p3;
        
        if(total >= 1500)
        {
            total = total - (total*0.30); 
            System.out.println("Tiene el 30% de descuento: " + total);
        }else if(total<1500 && total >=1000)
        {
            total = total - (total*0.20); 
            System.out.println("Tiene el 20% de descuento: " + total);
        }else if(total<=1000 && total >=700)
        {
            total = total - (total*0.30); 
            System.out.println("Tiene el 10% de descuento: " + total);
        }else
        {
            System.out.println(total);
        }
    }
}
