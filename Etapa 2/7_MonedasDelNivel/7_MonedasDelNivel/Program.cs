using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas monedas doradas agarraste wachin: ");
            int monedas1 = int.Parse(Console.ReadLine());
            Console.Write("Y cuantas plateadas wachin: ");
            int monedas2 = int.Parse(Console.ReadLine());
            int total1 = monedas1 * 10;
            int total2 = monedas2 * 2;
            int totalfinish = monedas1 + monedas2;
            if (totalfinish < 50)
            { Console.Write("no llegaste boludo xdd" + " " + "(" + totalfinish + ")"); }
            else if (totalfinish > 50 && totalfinish < 99)
            { Console.Write("nivel superado :D" + " " + "(" + totalfinish+ ")"); }
            else if (totalfinish > 100)
            { Console.Write("NIVEL SUPERADO CON BONUS!!!" + " " + "(" + totalfinish + ")"); }
            Console.ReadKey();



        }
    }
}
