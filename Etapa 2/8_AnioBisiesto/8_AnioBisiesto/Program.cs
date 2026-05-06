using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año al azar: ");
            double año = double.Parse(Console.ReadLine());
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) 
            { Console.Write("el año es bisiesto"); }
            else 
            { Console.Write("el año no es bisiesto"); }
            Console.ReadKey();

        }
    }
}
