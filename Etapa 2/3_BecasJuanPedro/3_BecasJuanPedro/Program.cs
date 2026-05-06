using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sus ingresos mensuales: ");
            int ingresos = int.Parse(Console.ReadLine());
            if (edad > 19 && ingresos <= 10000)
            { Console.Write("Cumple con los requerido "); }
            else
            { Console.Write("No cumple con lo requerido"); }
            Console.ReadKey();
        }
    }
}
