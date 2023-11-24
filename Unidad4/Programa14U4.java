/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa14u4;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa14U4 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int c, f, suma=0, nc=0,nf=0;
        
                System.out.println("Ingrese la cantidad de filas: ");
                f = sc.nextInt();
                    System.out.println("Ingrese la cantidad de columnas: ");
                c = sc.nextInt();
             
           
        int[][]nums = new int [f][c];
        
        for(int i=0; i<f; i++)
        {
            for(int j=0; j<c; j++)
            {
                System.out.println("Ingrese el numero: " );
                nums[nf][nc] = sc.nextInt();
                
                suma= suma + nums[nf][nc]; 
               }
        }
        System.out.println("La suma es: " + suma);
    }
}
