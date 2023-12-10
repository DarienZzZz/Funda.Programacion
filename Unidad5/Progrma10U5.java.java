/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
import java.util.Scanner;
import java.util.Random;
public class Main
{
	public static void main(String[] args) {
	Scanner sc = new Scanner(System.in);
       int longi=20; //Numero de letra, caracter o numoer
        String pass = random(longi);
        System.out.println("La connstraseña es: "+pass);
    }
    
    public static String random(int x){ //x es el tamaño
        //Caracteres
        String letras = "ABSLHDLHKAH/$%#&_jkjsaloqn"; //Doble comilla para string y comillas simpre para caracter
        Random alea = new Random(); //Funcion para que genere un numero aleatorio
        StringBuilder cadena = new StringBuilder(x); //Construir caracteres como un arreglo 
        for(int i=0; i<x; i++){
            /*Para darle un lugar de las letras que sea aleatorio y no uno fijo
            Ya que si se pone un numero fijo se pone lo mismo(1)*/
           int IndiceCaracter = alea.nextInt(letras.length()); //length cuenta las letras o numeros de caracteres
           /*Lo alamacena como si fuera un arreglo y el indice el valor*/
           cadena.append(letras.charAt(IndiceCaracter)); 
        
        }
        return cadena.toString(); //toString() el resultado lo conviertes en texto
    }
}