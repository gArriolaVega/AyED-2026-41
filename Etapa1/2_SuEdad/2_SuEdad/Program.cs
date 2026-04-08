using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SuEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad=int.Parse(Console.ReadLine());
            Console.Write("Su edad es:");
            Console.WriteLine(edad);
            Console.ReadKey();
        }
    }
}
