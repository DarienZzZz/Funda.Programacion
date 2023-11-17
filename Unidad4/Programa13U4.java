/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa13u4;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa13U4 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        
        float[][] cel = new float[5][7];
        float[][] far = new float[5][7];
        
        for(int i=0; i<5; i++)
        {
            for(int j=0; j<7; j++)
            {
                System.out.println("Ingrese la temperatura: "+ i + " " + j + " " );
                cel[i][j] = sc.nextFloat();
                
                far[i][j]=(cel[i][j]*9/5) + 32;
                
                System.out.println("La temperatura en Farenheit es: " + far[i][j]);
            }
        }
    }
}
