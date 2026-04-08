using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {

            double radio;
            double pi = 3.1416;
            Console.Write("Ingrese el radio de la esfera: ");
            radio = double.Parse(Console.ReadLine());
            double superficie = 4 * pi * Math.Pow(radio, 2);
            double volumen = 4 / 3 * pi * Math.Pow(radio, 3);
            Console.Write("La superficie de la esfera: " + superficie);
            Console.WriteLine(volumen);
            Console.Write("El volumen de la esfera es: " + volumen);
            Console.ReadKey();




            

     


                
        }
    }
}
