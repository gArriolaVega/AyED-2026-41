using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base: ");
            double base_triangulo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());
            double area = (base_triangulo * altura) / 2;
            Console.Write("El area del triangulo es: " + area);
            Console.ReadKey();
        }
    }
}
