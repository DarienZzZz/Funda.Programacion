/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa9u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa9U3 {

    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int h, costo, a=10, b=12, c=15;
        System.out.print("Ingrese las horas que estuvo en el estacionamiento: ");
        h=sc.nextInt();
        
        if(h<=2){
            costo=h*5;
            System.out.print("El costo es de: "+costo);
        }else if(h>2&&h<=5){
            costo=(h*4)+a;
            System.out.print("El costo es de: "+costo);
        }else if(h>5&&h<10){
            costo=(h*3)+a+b;
            System.out.print("El costo es de: "+costo);
        }else{
            costo=(h*2)+a+b+c;
            System.out.print("El costo es de: "+costo);
        }
        
        
    }
}