using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Saludar
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludar();
            Console.WriteLine(sumar(1, 2));
            Console.WriteLine(sumar((2 * 2), (3 * 2)));

            int a = 3;
            int b = 5;
            int c = 2;
            Console.WriteLine(sumar(a, b));
            Console.WriteLine(sumar(b, c));
            Console.WriteLine(sumar(sumar(a, b), (sumar(b, c));
            Console.WriteLine(SumarDos(SumarDos(SumarDos(SumarDos(SumarDos(SumarDos(c)))))));



          
        }

        static void Saludar()
        {
            Console.WriteLine("Hola");                    
        }
   
     

        static int sumar(int a, int b)
        {
            int resultado = a + b;
            return  resultado;

        }

        static int SumarDos(int a)
        {
            return a + 2;
        }

        static string SaludarA(string nombre)
        {
            return ("Hola" + nombre);
        }



        
        
    }
}
