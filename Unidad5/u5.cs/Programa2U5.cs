using System;

namespace Pro
{
    internal class Pro
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Eliga el proceso a realizar:");
            Console.WriteLine("1. Temperatura C a F");
            Console.WriteLine("2. Temperatura F a C");
            Console.WriteLine("3. Comvertir pulgadas a metros");
            Console.WriteLine("4. Comvertir horas a segundos");
            int opcion= Convert.ToInt32(Console.ReadLine());
            
            switch(opcion)
            {
                case 1:
                    double c;
                    Console.WriteLine("Ingresa la temperatura a en celcious: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultados: " + tempCtoF(c));
                    break;
                case 2:
                    Console.WriteLine("Resultados: " + tempftok());
                    break;
                case 3:
                    PulToMet();
                    break;
                case 4:
                    HorToSeg();
                    break;
            }
        }
        public static double tempCtoF(double c)
        {
            double resultado = (c * 1.8) + 32;
            return resultado;
        }
        public static double tempftok()
        {
            double f, res=0;
            Console.WriteLine("Ingresa la temperatura a en farenheit: ");
            f = Convert.ToDouble(Console.ReadLine());
            res = (f-32)*(5/9) + 273.15;
            return res;
        }
        public static void PulToMet()
        {
            double pul, res = 0;
            Console.WriteLine("Ingresa las pulgadas: ");
            pul = Convert.ToDouble(Console.ReadLine());
            res = pul * 39.37;
        }
        public static void HorToSeg()
        {
            double hora, res = 0;
            Console.WriteLine("Ingresa las horas: ");
            hora = Convert.ToDouble(Console.ReadLine());
            res = hora * 3600;
        }
    }
}

