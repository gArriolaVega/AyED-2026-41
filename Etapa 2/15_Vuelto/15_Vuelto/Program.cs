using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("el monto es de:  ");
            int factura = int.Parse(Console.ReadLine());

            Console.Write("pagas?: ");
            int monto_pagar = int.Parse(Console.ReadLine());

            int vuelto = monto_pagar - factura;
            if (vuelto < 0)

            {
                Console.Write("te falta plata boludin");
            }

            else if (factura == monto_pagar)
            {
                Console.Write("listooooo");
            }

            else if (vuelto > 0)
            {

                Console.WriteLine("Vuelto total: " + vuelto);
                Console.WriteLine("los billetes van a ser asi:");
                int billete10000 = vuelto / 10000;
                vuelto = vuelto % 10000;
                int billete2000 = vuelto / 2000;
                vuelto = vuelto % 2000;
                int billete1000 = vuelto / 1000;
                vuelto = vuelto % 1000;
                int billete500 = vuelto / 500;
                vuelto = vuelto % 500;
                int billete200 = vuelto / 200;
                vuelto = vuelto % 200;
                int billete100 = vuelto / 100;
                vuelto = vuelto % 100;
                int billete50 = vuelto / 50;
                vuelto = vuelto % 50;

                int billete20 = vuelto / 20;
                vuelto = vuelto % 20;

                int billete10 = vuelto / 10;
                vuelto = vuelto % 10;
                Console.WriteLine("10000: " + billete10000);
                Console.WriteLine("2000: " + billete2000);
                Console.WriteLine("1000: " + billete1000);
                Console.WriteLine("500: " + billete500);
                Console.WriteLine("200: " + billete200);
                Console.WriteLine("100: " + billete100);
                Console.WriteLine("50: " + billete50);
                Console.WriteLine("20: " + billete20);
                Console.WriteLine("10: " + billete10);
            }     
            Console.ReadKey();





        }
    }
}
        
