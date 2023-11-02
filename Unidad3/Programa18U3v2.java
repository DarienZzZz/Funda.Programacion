/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa18u3v2;

import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class Programa18U3v2 {

    public static void main(String[] args) {

        Scanner sc = new Scanner (System.in);
        int i;
        double s=1500, a=1, ta=1,su=0;
    for(i=1;i<=6;i++)
       {
        a= s * 0.1;
        s= a + s;
        ta=(s*12);
        System.out.println("Su sueldo durante todo el año es: " + s);
        
        System.out.println("Su salario bruto en el año es: " + ta);
        
        su=su + ta;
       }
       
        System.out.println("Su sueldo al cabo de 6 años: " + su); 
    }
}
