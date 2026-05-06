using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido el simulador");
            Console.WriteLine("----Menu----");
            Console.WriteLine("En el caso de encontrarte un puma que harias:");
            Console.WriteLine("Opcion 1: Correr");
            Console.WriteLine("Opcion 2: Asustarlo");
            Console.WriteLine("Opcion 3: Cagarlo a ñapis ");
            Console.WriteLine("Salir ");
            Console.Write("Elige la opcion: ");
            bool salir = true;
            while (salir == true) 
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cagaste el puma es mas rapido xd");
                        break;
                    case 2:
                        Console.WriteLine("Cagaste el puma que te va a tener miedo a vos boludin");
                        break;
                    case 3:
                        Console.WriteLine("Moriste, quien pelea contra un puma tarado");
                        break;
                    default:
                        Console.WriteLine("Pone bien la opcion wachin");
                        break;


                }

            }
            Console.ReadKey();

        }
    }
}
