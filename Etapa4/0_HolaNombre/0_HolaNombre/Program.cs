using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = HolaNombre("enzocerobulto");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        static string HolaNombre(string nombre)
        {
            return "Hola " + nombre;
        }

        

    }
}
