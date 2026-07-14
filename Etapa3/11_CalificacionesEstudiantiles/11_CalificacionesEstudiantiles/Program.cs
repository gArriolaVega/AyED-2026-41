using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de personas: ");
            int n = int.Parse(Console.ReadLine());

            string[,] matriz = new string[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPersona " + (i + 1));

                Console.Write("Nombre: ");
                matriz[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                matriz[i, 1] = Console.ReadLine();

                Console.Write("Calificación: ");
                matriz[i, 2] = Console.ReadLine();
            }

            Console.WriteLine("\nNombre\tEdad\tCalificación");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, 0] + "\t" + matriz[i, 1] + "\t" + matriz[i, 2]);
            }
            Console.ReadKey();
        }
    }
}
