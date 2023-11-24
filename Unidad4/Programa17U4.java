/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa17u4;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa17U4 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int c, f,mul=0;
        
                System.out.println("Ingrese la cantidad de filas: ");
                f = sc.nextInt();
                    System.out.println("Ingrese la cantidad de columnas: ");
                c = sc.nextInt();
             
        int[][]matrix = new int [f][c];
        int[][]matrix2 = new int [f][c];
         //System.out.println(f+""+ c);
        
        for(int i=0; i<f; i++)
        {
            for(int j=0; j<c; j++)
            {
                System.out.println("Ingrese el dato del primer arreglo: " );
                matrix[i][j] = sc.nextInt();
                System.out.println("Ingrese el dato del segundo arreglo: " );
                matrix2[i][j]= sc.nextInt();
           
                mul= matrix[i][j]*matrix2[i][j];
                System.out.println("Resultados: " +  mul);
               }
          
        }
        
    }
}
