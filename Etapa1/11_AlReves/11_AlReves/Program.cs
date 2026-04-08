using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera letra: ");
            string letra1 = Console.ReadLine();
            Console.Write("Ingrese la segunda letra: ");
            string letra2 = Console.ReadLine();
            Console.Write("Ingrese la ultima letra: ");
            string letra3 = Console.ReadLine();
            Console.Write("Las letras en orden inverso: ");
            Console.WriteLine(letra3 + letra2 + letra1);
            Console.ReadKey();
        }
    }
}
