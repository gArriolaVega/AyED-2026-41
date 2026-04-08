using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero: ");
            int numero_entero = int.Parse(Console.ReadLine());
            int numero_doble = numero_entero * 2;
            int numero_triple = numero_entero * 3;
            Console.WriteLine("el doble de " + numero_entero + " es igual a: " + numero_doble + " y el triple es: " + numero_triple);
            Console.ReadKey();
        }
    }
}
