using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            const string contraseña = "pepito57";
            Console.Write("Ingrese su contraseña: ");
            string verificacion = Console.ReadLine();
            string verificacion2 = verificacion.ToLower();
            if (verificacion == contraseña)
            {Console.Write("La contraseña es correcta :)"  ); }
            else
            { Console.Write("La contraseña esta mal wachin"); }
            Console.ReadKey();

        }
    }
}
