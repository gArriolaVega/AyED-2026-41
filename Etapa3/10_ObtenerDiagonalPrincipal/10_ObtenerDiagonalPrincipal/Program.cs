using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila = 4;
            int columna = 4;
            Random random = new Random();
            int[,] matriz = new int[fila, columna];

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                }
            }
            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine(" ");
                Console.Write("[ ");
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("] ");
            }
            Console.WriteLine();
            int[] Diagonal = new int[fila];
            for (int i = 0; i < fila; i++)
            {
                Diagonal[i] = matriz[i, i];
                Console.WriteLine($" ");
            }
            Console.Write(" ]");
            for (int i = 0; i < Diagonal.Length; i++)
            {
                Console.Write($"  {Diagonal[i]} ");
            }
            Console.Write(" ]");
            Console.ReadKey();
        }
        
    }
}
