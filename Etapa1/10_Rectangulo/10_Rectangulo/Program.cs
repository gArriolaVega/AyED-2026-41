using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double perimetro;
            double area;
            double diagonal;
            Console.Write(" Ingrese el ancho: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura: ");
            y = double.Parse(Console.ReadLine());
            perimetro = 2 * (x + y);
            area = x * y;
            diagonal = Math.Sqrt(x * x + y * y);
            Console.WriteLine("el perimetro: " + perimetro);
            Console.WriteLine("el area: " + area);
            Console.WriteLine("la diagonal: " + diagonal);
            Console.ReadKey();




        }
    }
}
