/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa17u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa17U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        char idk;
        
        do
        {
            System.out.println("Bienvenido a una sala de ejecucion");
            System.out.println("Escribe n para no condenar a muerte");
            idk=sc.next().charAt(0);
        }while(idk != 'n');
                
    }
}
