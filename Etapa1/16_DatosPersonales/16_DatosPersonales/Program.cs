using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("ingrese su apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("ingrese su edad: ");
            string edad = Console.ReadLine();
            Console.Write("ingrese la ciudad donde vive: ");
            string ciudad = Console.ReadLine();
            Console.Write("su nombre completo es " + nombre + " " + apellido + " su edada es " + edad + " y vive en " + ciudad);
            Console.ReadKey();
        }
    }
}
