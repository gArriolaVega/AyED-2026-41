using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una medida en metros: ");
            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100;
            double milimetros = metros * 1000;
            Console.WriteLine("La medida en centimetros es de: " + centimetros);
            Console.WriteLine("La medida en milimetros es de: " + milimetros);
            Console.ReadKey();
            
        }
    }
}
