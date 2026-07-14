using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int examenes_total = 0;
            int examenes_aprobados = 0;
            int TPs_aprobados = 0;
            float porcenatje_TPs = 0;

            Console.WriteLine("Cuantos TPs son: ");
            int TPs = int.Parse(Console.ReadLine());
            int[] TPs_lista = new int[TPs];

            Console.WriteLine("Y cuantos examenes son: ");
            int examenes = int.Parse(Console.ReadLine());
            int[] examenes_lista = new int[examenes];

            for (int i = 0; i < examenes_lista.Length; i++)
            {
                Console.Write("Nota del examen " + (i + 1) + ": ");
                examenes_lista[i] = int.Parse(Console.ReadLine());
                if (examenes_lista[i] > 10)
                {
                    Console.Clear();
                    Console.WriteLine("Error xd ");
                }
            }
            for (int i = 0; i < TPs_lista.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nota del TP " + (i + 1) + ": ");
                TPs_lista[i] = int.Parse(Console.ReadLine());
                if (TPs_lista[i] > 10) 
                {
                    Console.Clear();
                    Console.WriteLine("Error xd "); 
                }
            }
            for (int i = 0; i < examenes_lista.Length; i++)
            {
                examenes_total = examenes_total + examenes_lista[i];
            }
            examenes_aprobados = examenes_total / examenes_lista.Length;

            for (int i = 0; i < TPs_lista.Length; i++)
            {
                if (TPs_lista[i] >= 6)
                {
                    TPs_aprobados++;
                }
            }
            Console.Clear();
            porcenatje_TPs = (TPs_aprobados * 100) / TPs_lista.Length;
            if (examenes_aprobados > 6 || porcenatje_TPs > 76)
            {
                Console.Clear();
                Console.Write("Phineas y Ferb aprobaron con exito los examenes :D");
                Console.Write("");
                Console.Write("");
                Console.WriteLine($"El promedio que tuvieron fue de:  {examenes_aprobados}");
                Console.Write("");
                Console.Write("");
                Console.WriteLine($"El porcentaje que tuvieron fue de: {porcenatje_TPs} %");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Phineas y Ferb acaban de reprobar el fukin año asi que son altos bobis XD ");
                Console.Write("");
                Console.Write("");
                Console.WriteLine($"El promedio que tuvieron fue de:  {examenes_aprobados}");
                Console.Write("");
                Console.Write("");
                Console.WriteLine($"El porcentaje que tuvieron fue de: {porcenatje_TPs} %");

            }
            Console.ReadKey();

        }
    } 
}
