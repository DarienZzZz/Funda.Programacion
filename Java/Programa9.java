/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa9;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa9 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        double n1, n2,div, sum, res, mul;
        System.out.print("Ingrese valor 1:");
        n1 = sc.nextDouble();
        System.out.print("Ingrese valor 1:");
        n2 = sc.nextDouble();
        
        sum= n1 +n2;
        res = n1-n2;
        mul= n1*n2;
        div=n1/n2;
        System.out.println("La suma es: "+ sum);
        System.out.println("La resta es: "+ res);
        System.out.println("La multiplicasion es: "+ mul);
        System.out.println("La Division: "+ div);
        
    }
}
