using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Ingrese la edad del estudiante" + (i + 1) + ":");
                edades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Edades cargadas: ");

                for (int i = 0; i < edades.Length; i++)
                {
                    Console.WriteLine("Edad" + (i + 1) + ":" + edades[1]);
                }
                Console.ReadKey();

        }
    }
}
