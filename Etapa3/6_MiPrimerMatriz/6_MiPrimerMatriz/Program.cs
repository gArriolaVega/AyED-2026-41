using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de filas de la matriz: ");
            int fila = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Cantidad de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, columnas];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
