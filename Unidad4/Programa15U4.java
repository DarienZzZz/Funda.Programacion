/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa15u4;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa15U4 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int c, f;
        double suma=0;
        
                System.out.println("Ingrese la cantidad de filas: ");
                f = sc.nextInt();
                    System.out.println("Ingrese la cantidad de columnas: ");
                c = sc.nextInt();
             
           
        int[][]matrix = new int [f][c];
        
        for(int i=0; i<f; i++)
        {
            for(int j=0; j<c; j++)
            {
                System.out.println("Ingrese el numero: " );
                matrix[i][j] = sc.nextInt();
                
                suma=(suma + matrix[i][j])/f;
               }
             System.out.println("La media es: " + suma);
        }
        
    }
}
