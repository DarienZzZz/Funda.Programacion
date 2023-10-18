/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa2U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int edad;
        
        System.out.println("Ingresa tu edad:");
        edad=sc.nextInt();
        
        if (edad>=18)
        {
            System.out.println("Eres Mayor");
        }else
        {
            System.out.println("Eres Menor");
        }
    }
}
