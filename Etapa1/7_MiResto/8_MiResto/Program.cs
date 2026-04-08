using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.Write("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1  numero2;
            Console.Write("El resultado es: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
