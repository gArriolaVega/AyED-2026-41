using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            double numero1 = double.Parse(Console.ReadLine());
            double numero_cuadrado = Math.Pow(numero1, 2);
            double numero_cubo = Math.Pow(numero1, 3);
            Console.WriteLine("el doble de " + numero1 + " es igual a: " + numero_cuadrado + " y el triple es: " + numero_cubo);
            Console.ReadKey();
        }
    }
}
