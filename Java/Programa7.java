/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa7;
import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa7 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int metros;
        double pies;
        
        System.out.print("Ingrese los metros a :");
        metros = sc.nextInt();
        
        pies= metros * 3.281;
        System.out.print("Los pies son: "+ pies);
    }
}
