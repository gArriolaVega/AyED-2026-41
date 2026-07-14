using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int fila = random.Next(1, 100);
            Console.Clear();
            int columna = random.Next(1, 100);
            int[,] matriz = new int[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
