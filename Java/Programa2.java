package com.mycompany.programa2;
import java.util.Scanner; //Libreria ingresar datos 

public class Programa2 {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);// Mandar a llamar a el objeto
        int num1, num2,suma;
        
        System.out.print("Escribe un numero:");
        num1 = sc.nextInt(); //nextInt(); Para comvertir datos a entero
        System.out.print("Escribe otro numero:");
        num2 = sc.nextInt();
        
        suma = num1 + num2;
        System.out.println("Resultados: " + suma);        
    }
}
   
