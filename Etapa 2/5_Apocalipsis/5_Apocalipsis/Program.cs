using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tenes una fukin arma bro?: ");
            bool pistola = Console.ReadLine().ToLower() == "si";
            Console.Write("Tene fukin comida?:  ");
            bool comida = Console.ReadLine().ToLower() == "si";
            Console.Write("Você tem refúgio?: ");
            bool casita = Console.ReadLine().ToLower() == "si";
            if ( comida && pistola)
            { Console.Write("Si sobrevivis vamaaa"); }
            else
            { Console.Write("No sobrevivis :("); }
            Console.ReadKey();
         }
    }
}
