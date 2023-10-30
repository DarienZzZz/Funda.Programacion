/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa18u3;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa18U3 {

    public class Programa18U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        int i;
        double s=1500, a=1, ta=1;
    for(i=1;i<=6;i++)
       {
        System.out.println("Su sueldo por año es: " + s);
        a= s * 0.10;
        s= s + a;
       }
       ta= ta + s;
        System.out.println("Su sueldo al cabo de 6 años: " + ta); 
    }

}