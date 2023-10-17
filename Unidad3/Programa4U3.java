/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa4u3;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa4U3 {

    
        
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int mes;
        System.out.println("Ingresa el numero de mes:");
        mes= sc.nextInt();
        
        switch(mes)
        {
                case 1:
                System.out.println("Es Enero");
                break;
                case 2:
                System.out.println("Es Febrero");
                break;
                case 3:
                System.out.println("Es Marzo");
                break;
                case 4:
                System.out.println("Es Abril");
                break;
                case 5:
                System.out.println("Es Mayo ");
                break;
                case 6:
                System.out.println("Es Junio");
                break;
                case 7:
                System.out.println("Es Julio");
                break;
                case 8:
                System.out.println("Es Agosto");
                break;
                case 9:
                System.out.println("Es Septiembre");
                break;
                case 10:
                System.out.println("Es Octubre");
                break;
                case 11:
                System.out.println("Es Noviembre");
                break;
                case 12:
                System.out.println("Es Diciembre");
                break;
                default: System.out.println("No existe ese mes");
        
}
    }
}
