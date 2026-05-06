using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura: ");
            int gradosC = int.Parse(Console.ReadLine());
            if ( gradosC <= 0)
            { Console.Write("El agua se congelo"); }
            if ( gradosC >= 100)
            { Console.Write("Esta invierdo el agua"); }
            if ( gradosC >= 1 && gradosC <= 99)
            { Console.Write("El agua se encuentra en estado liquido"); }
            Console.ReadKey();
        }
    }
}
