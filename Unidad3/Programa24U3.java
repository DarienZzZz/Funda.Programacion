/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa24u3;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa24U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int num;
        
        do
        { 
        System.out.println("Ingrese un numero:(Ingrese numero negativo para acabar)");
        num=sc.nextInt();
            if(num%2==0)
            {
                System.out.println("Es par");
            }else
            {
                System.out.println("Es impar");    
            }
        }while(num>0);

    }
}
