/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa3u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa3u3{

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int dia;
        
        System.out.println("Ingresa el dia:");
        dia=sc.nextInt();
        
        switch(dia)
        {
                case 1:
                System.out.println("Es lunes");
                break;
                case 2:
                System.out.println("Es martes");
                break;
                case 3:
                System.out.println("Es miercoles");
                break;
                case 4:
                System.out.println("Es jueves");
                break;
                case 5:
                System.out.println("Es viernes");
                break;
                case 6:
                System.out.println("Es sabado");
                break;
                case 7:
                System.out.println("Es domingo");
                break;
                
                default: System.out.println("No existe ese dia");
                
        }
    }
}
