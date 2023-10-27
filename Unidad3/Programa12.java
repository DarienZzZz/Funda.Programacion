/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa12;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa12 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
       int c, total, num;
        
        System.out.println("Ingresa la cantidad de valores totales:");
        total = sc.nextInt();
        
        for(c=1;c<=total;c++)
        {
            System.out.println("Ingresa el numero:");
            num = sc.nextInt();
            
            if(num%2==0)
            {
                System.out.println("Es un numero par");
            }else
            {
                System.out.println("Es un numero impar");
            }
        }
        
    }
}
