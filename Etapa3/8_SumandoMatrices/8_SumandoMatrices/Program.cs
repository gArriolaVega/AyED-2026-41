using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[filas, columnas];
            int[,] matriz2 = new int[filas, columnas];
            int[,] matriz3 = new int[filas, columnas];

            Random rnd = new Random();
            for ( int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz1[i, j] = rnd.Next(1, 11);
                    matriz2[i, j] = rnd.Next(1, 11);
                    matriz3[i, j] = matriz1[i, j] = matriz2[i, j];
                }
            }
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("Matriz 1: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz1[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.Write(" ");
            Console.WriteLine("Matriz 2: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz2[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.Write(" ");
            Console.WriteLine("Resultado: ");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz3[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
