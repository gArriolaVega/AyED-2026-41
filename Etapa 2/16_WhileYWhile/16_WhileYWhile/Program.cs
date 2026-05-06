using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador_numero1 = 0;
            while (contador_numero1 <= 100)
            {
                if (contador_numero1 % 2 == 0)
                {
                    Console.Write(" " + contador_numero1);
                }
               contador_numero1 = contador_numero1 + 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("");
            int contador_numero2 = 0;
            while (contador_numero2 <= 100)
            {
                if (contador_numero2 % 2 != 0)
                {
                    Console.Write(" " + contador_numero2);
                }
                contador_numero2 = contador_numero2 + 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("");
            int contador_numero3 = 0;
            while (contador_numero3 <= 100)
            {
                Console.Write(" " + contador_numero3);
                contador_numero3 = contador_numero3 + 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("");
            int contador_numero4 = 100;
            while (contador_numero4 >= 0)
            {
                {
                    Console.Write(" " + contador_numero4);
                }
                contador_numero4 = contador_numero4 - 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("");
            int contador_numero5 = 0;
            while (contador_numero5 <= 100)
            {
                if (contador_numero5 % 3 == 0)
                {
                    Console.Write(" " + contador_numero5);
                }
                contador_numero5 = contador_numero5 + 1;
            }
            Console.WriteLine(" ");
            Console.WriteLine("");
            int contador_numero6 = 0;
            while (contador_numero6 <= 100)
            {
                if (contador_numero6 % 3 == 0 && contador_numero6 % 2 == 0)
                {
                    Console.Write(" " + contador_numero6);
                }
                contador_numero6 = contador_numero6 + 1;
            }
            Console.ReadKey();            
        }
    }

}
        