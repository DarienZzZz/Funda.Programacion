/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa4;
import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa4 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int y, a, x;
        
        System.out.print("Escribe la Y:");
        y = sc.nextInt(); //nextInt(); Para comvertir datos a entero
        System.out.print("Escribe la A:");
        a = sc.nextInt();
        
        x= y + a + 3;
        System.out.print("Resultado de x= a + y + 3 es: " + x);
    }
}
