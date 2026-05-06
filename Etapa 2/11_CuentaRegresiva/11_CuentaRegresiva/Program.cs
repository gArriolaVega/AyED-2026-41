using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero: ");
            int entero = int.Parse(Console.ReadLine());
            while ( entero != -1)
            {
                Console.WriteLine(" " + entero);
                entero -= 1;

                
            }
            Console.ReadKey();
        }
    }
}
