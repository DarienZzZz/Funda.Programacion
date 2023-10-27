/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa16u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa16U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int i=1,h,p,s;
        
        while(i<=20)
        {
            System.out.println("Ingresa la cantidad de horas trabajadas:");
            h = sc.nextInt();
            System.out.println("Ingresa el pago por hora:");
            p = sc.nextInt();
            s= h * p;
            System.out.println("Su sueldo es: " + s);
            i++; //!!! Poner el incremento !!!
        }
    }
}
