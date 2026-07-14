using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int promedio = 0;
            Console.WriteLine("Cuantos invitados son: ");
            int invitados = int.Parse(Console.ReadLine());
            int[] vectorgas = new int[invitados];
            Console.WriteLine("La comida debe estar entre 0 y/o 100");
            for (int i = 0; i < vectorgas.Length; i++)
            {
                Console.WriteLine("Comida del invitado " + ( i + 1) + ":" );
                vectorgas [ i ] =  int.Parse(Console.ReadLine());
                if (vectorgas[i] > 100)
                {
                    Console.Clear();
                    Console.Write("Error xd ");
                }

            }
            for (int i = 0; i < vectorgas.Length; i++)
            {
                total = total + vectorgas[i];
            }
            promedio = total / vectorgas.Length;
            for (int i = 0; i < vectorgas.Length; i++)
            {
                Console.WriteLine("Comida para el invitado " + (i + 1) + ":" + promedio);

            }
            Console.ReadKey();
        }
    }
}
