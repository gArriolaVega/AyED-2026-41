using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer lado: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer lado: ");
            int lado3 = int.Parse(Console.ReadLine());
            if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
            { Console.Write("Obtuviste un triangulo equilatero"); }
            if (lado1 == lado2 && lado1 != lado3)
            { Console.Write("Obtuviste un triangulo isoseles"); }
            if (lado1 != lado2 && lado1 != lado3)
            { Console.Write("Obtuviste un triangulo escaleno"); }
            Console.ReadKey();

        }
    }
}
