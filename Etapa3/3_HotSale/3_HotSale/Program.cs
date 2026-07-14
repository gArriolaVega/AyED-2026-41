using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos productos fueron vendidos?: ");
            int productos = int.Parse(Console.ReadLine());
            int[] lista_productos = new int[productos];

            int PMenor = 0;
            int PMayor = 0;

            for (int i = 0; i < lista_productos.Length; i++)
            {
                Console.Write("Precio del producto " + (i + 1) + ":");
                lista_productos [i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Array.Sort(lista_productos);
            PMenor = lista_productos[0];
            Array.Reverse(lista_productos);
            PMayor = lista_productos[0];

            Console.Write($"El producto mas caro fue { PMayor} y el producto mas barato fue {PMenor}");

            Console.ReadKey();
        }
        
    }
}
