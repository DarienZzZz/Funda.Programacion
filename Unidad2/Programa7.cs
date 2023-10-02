using System;

class Calculadora
{
    static void Main(string[] args)
    {
        int num1, num2, sum, rest, multi;
        double div;

        Console.WriteLine("Ingrese el numero 1:");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el numero 1:");
        num2 = Int32.Parse(Console.ReadLine());
        
        sum=num1+num2;
        rest=num1-num3;
        mult=num1*num2;
        div=num1/num2;
        Console.WriteLine("La suma es: " + sum);
        Console.WriteLine("La resta es: " + rest);
        Console.WriteLine("La multiplicacion es: " + multi);
        Console.WriteLine("La division es: " + div);
    }
}