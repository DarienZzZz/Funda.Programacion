

package com.mycompany.programa6u3;
import java.util.Scanner;
/**
 *
 * @author alexr
 */
public class Programa6U3 {

    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int num=0;
        System.out.print("Ingrese un número entero: ");
        num=sc.nextInt();
        
        if(num%2==0){
            System.out.print("El numero es par.");
        }else{
            System.out.print("El número es impar.");
        }
    }
}