using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            float numero3 = float.Parse(Console.ReadLine());
            float promedio = (numero1 + numero2 + numero3) / 3;
            Console.Write("Tu promedio es de: " + promedio);
            Console.ReadKey();

        }
    }
}
