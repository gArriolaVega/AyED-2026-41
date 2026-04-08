using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheit;
            double celcius;
            double kelvin;
            Console.Write("Ingrese la temperatura es celcius: ");
            celcius = double.Parse(Console.ReadLine());
            kelvin = celcius + 273.15;
            farenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("La temperatura es kelvin es: " + kelvin);
            Console.WriteLine("La temperatura en farenheit es: " + farenheit);
            Console.ReadKey();
        }
    }
}
