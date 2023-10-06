
package com.mycompany.programa5;
import java.util.Scanner;

public class Programa5 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int L1, L2 ,L3 , h, b, area, peri;
        
        
        System.out.print("Escribe la Altura:");
        h = sc.nextInt(); //nextInt(); Para comvertir datos a entero
        System.out.print("Escribe la Base:");
        b = sc.nextInt();
        System.out.print("Escribe el Lado 1:");
        L1 = sc.nextInt();
        System.out.print("Escribe el Lado 2:");
        L2 = sc.nextInt();
        System.out.print("Escribe el Lado 3:");
        L3 = sc.nextInt();
        
        area = (b * h) /2;
        peri = L1*L2*L3;
        System.out.print("El area es: " + area);
        System.out.print("El peri es: " + peri);
    }
}
