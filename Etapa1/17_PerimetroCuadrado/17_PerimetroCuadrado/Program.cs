using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una longitud de un lado de su cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            double perimetro = 4 * lado;
            double superficie = lado * lado;
            Console.Write("El perimetro es de: " + perimetro + "  Y el area es de: " + superficie);
            Console.ReadKey();
        }
    }
}
