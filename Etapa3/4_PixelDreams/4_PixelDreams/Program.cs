using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos participantes son: ");
            int participantes = int.Parse(Console.ReadLine());
            int[] lista_puntos = new int[participantes];
                for (int i = 0; i <= lista_puntos.Length; i++)
            {
                Console.Write("Puntaje del participante " + (i + 1) + ":");
                lista_puntos[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Array.Sort(lista_puntos);

            Console.WriteLine("Puntajes ordenados en mayor a menor es: ");
            Console.WriteLine(string.Join(", ", lista_puntos));
            Console.ReadKey();

        }
    }
}
