using System;

namespace Promedios;

class promedio
{
    static void Main(string[] args)
    {
        float cal1, cal2, cal3, cal4, cal5, cal6, prom;
        string nombre; 

        Console.WriteLine("Escribe tu Nombre:");
        nombre = Console.ReadLine();
        Console.WriteLine("Escribe tu Primera Calificacion:");
        cal1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu Segunda Calificacion:");
        cal2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu Tercera Calificacion:");
        cal3 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu Cuarte Calificacion:");
        cal4 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu Quinta Calificacion:");
        cal5 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu Sexta Calificacion:");
        cal6 = Int32.Parse(Console.ReadLine());

        prom = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6) / 6;

        Console.WriteLine("Tu Nombre es:" + nombre + "Tu Promedio es:" + prom);
    }
}


