/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa22u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa22U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int num, suma=0;
        
        do
        {
           System.out.println("Ingresa un numero:(Ingrese 0 para terminar)"); 
           num=sc.nextInt();
           suma = suma + num;
           System.out.println("----------------->suma");
           System.out.println(suma);
        }while(num!=0);

    }
}
