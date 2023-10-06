/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa10;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa10 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int lado, a, peri, area;
        System.out.print("Ingrese el apotema:");
        a = sc.nextInt();
        System.out.print("Ingrese el lado:");
        lado = sc.nextInt();
        
        peri = lado * 6;
        area = (peri * a) / 2;
        
        System.out.print("Ingrese el area es: " + area);
    }
}
