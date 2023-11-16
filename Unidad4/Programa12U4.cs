using System;

namespace Pro
{
    internal class Pro
    {
        static void Main(string[] args)
        {
            int[,] num = { { 5, 7, 8,5 }, { 8, 5, 6,5 }, { 5, 9, 5 ,5} };

            int fila = num.GetLength(0);
            int col = num.GetLength(0);

            for (int i = 0; i<fila;i++)
            { 
                for (int j = 0;j<col;j++)
                {
                    Console.Write(num[i, j] + " ");
                }
                Console.WriteLine();
            }

         
        }
           
    }
        
}
