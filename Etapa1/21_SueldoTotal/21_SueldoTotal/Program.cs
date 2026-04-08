using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su sueldo: ");
            int sueldo = int.Parse(Console.ReadLine());
            int sueldo_total = sueldo * horas;
            Console.WriteLine("Su sueldo total es de: " + sueldo_total);
            Console.ReadKey();



        }
    }
}
