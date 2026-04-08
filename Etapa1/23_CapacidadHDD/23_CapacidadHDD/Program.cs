using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de cilindros: ");
            double cilindros = double.Parse(Console.ReadLine());
            Console.Write("Ingrese las pistas por cilindro: ");
            double pista_cilindros = double.Parse(Console.ReadLine());
            Console.Write("Ingrese los sectores: ");
            double sectores = double.Parse(Console.ReadLine());
            double bytes = 512;
            double kilobytes = bytes / 1024;
            double megabytes = kilobytes / 1024;
            double gigabytes = megabytes / 1024;
            double capacidad = cilindros * pista_cilindros * sectores;
            Console.WriteLine("La capacidad en total es de: " + capacidad);
            Console.WriteLine("Capacidad en kilobytes: " + kilobytes);
            Console.WriteLine("Capacidad en megabytes: " + megabytes);
            Console.WriteLine("Capacidad en gigabytes: " + gigabytes);
            Console.ReadKey();


        }
    }
}
