using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            int n = 3;


            for (int i = 0; i < n; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("]");
            }
            Console.WriteLine();



            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {

                    int temporal = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = temporal;
                }
            }



            for (int i = 0; i < n; i++)
            {
                int inicio = 0;
                int fin = n - 1;

                while (inicio < fin)
                {

                    int temporal = matriz[i, inicio];
                    matriz[i, inicio] = matriz[i, fin];
                    matriz[i, fin] = temporal;

                    inicio++;
                    fin--;
                }
            }



            Console.WriteLine("    MATRIZ ROTADA 90 GRADOS   ");
            Console.WriteLine(" ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("]");
            }


            Console.ReadLine();
        }
    }
    }

