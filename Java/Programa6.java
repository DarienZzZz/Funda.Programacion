/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa6;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa6 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int fare, cen;
        
        System.out.print("Ingrese los grados centigrados:");
        cen = sc.nextInt();
        
        fare= (cen * 9/5) +32;
        System.out.print("Los grados Farenheit son: " + fare);
    }
}
