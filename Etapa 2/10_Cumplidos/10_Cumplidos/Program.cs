using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            int contador = 0;
            while (edad >= contador)
            {
                Console.WriteLine(" " + contador);
                contador += 1;

            }
            Console.ReadKey();
        }
    }
}
