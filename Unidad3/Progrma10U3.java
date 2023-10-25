/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.progrma10u3;
import java.util.Scanner;
/**
 *
 * @author alexr
 */
public class Progrma10U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int h,h2=40, su, ph, ex;
        System.out.print("Pago por hora: ");
        ph=sc.nextInt();
        System.out.print("Cuantas horas trabajo a la semana: ");
        h=sc.nextInt();
              
        if(h>40){
            ex=h-40;
            ex=ex*ph*2;
            su=(h2*ph)+ex;
            System.out.println("Su pago es de:  "+sueldo);
        }else{
            su=h*ph;
            System.out.println("Su pago es de:  "+sueldo);
        }
    }
}