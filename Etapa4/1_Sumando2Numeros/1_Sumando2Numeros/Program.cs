using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sumar2Numeros(5, 7);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.ReadKey();
        }
        static int Sumar2Numeros(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
    }
}
