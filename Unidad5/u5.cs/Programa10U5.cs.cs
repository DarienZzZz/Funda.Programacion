/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
   int longitud=8;
        Console.Write("Password: "+random(longitud));
    }
    public static String random(int x){ //x es el tamaño    
        //Caracteres
        string letras = "ABSLHDLHKAH/$%#&_jkjsaloqn"; //Doble comilla para string y comillas simpre para caracter
        StringBuilder cadena = new StringBuilder(x); //Construir caracteres como un arreglo 
        Random alea = new Random(); //Funcion para que genere un numero aleatorio
       
        for(int i=0; i<x; i++){
            /*Para darle un lugar de las letras que sea aleatorio y no uno fijo
            Ya que si se pone un numero fijo se pone lo mismo(1)*/
           int IndiceCaracter = alea.Next(letras.Length); //length cuenta las letras o numeros de caracteres
           /*Lo alamacena como si fuera un arreglo y el indice el valor*/
           cadena.Append(letras[IndiceCaracter]); 
        
        }
        return cadena.ToString(); //toString() el resultado lo conviertes en texto
    }
}