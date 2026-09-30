using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Balatrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MINI BALATRO ===");
            Console.WriteLine();

            string[] mano = GenerarManoAleatoria();
            string tipo = TipoDeMano(mano);
            int basePts = PuntajeBase(mano);
            double mult = Multiplicador(tipo);
            double total = basePts * mult;

            bool jokerX2 = true;
            bool jokerMas10 = true;

            total = AplicarJokers(total, jokerX2, jokerMas10);

            MostrarResumen(mano, tipo, basePts, mult, total);
        }

        static string[] GenerarManoAleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };
            string[] mano = new string[5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                string rango = rangos[rand.Next(0, rangos.Length)];
                string palo = palos[rand.Next(0, palos.Length)];
                mano[i] = rango + palo;
            }

            return mano;
        }

        static string TipoDeMano(string[] mano)
        {
            Dictionary<char, int> conteoRangos = new Dictionary<char, int>();

            foreach (string carta in mano)
            {
                char rango = carta[0];
                if (conteoRangos.ContainsKey(rango))
                {
                    conteoRangos[rango]++;
                }
                else
                {
                    conteoRangos[rango] = 1;
                }
            }

            bool tiene4 = false;
            bool tiene3 = false;
            int cantidadPares = 0;

            foreach (var par in conteoRangos)
            {
                if (par.Value == 4) tiene4 = true;
                if (par.Value == 3) tiene3 = true;
                if (par.Value == 2) cantidadPares++;
            }

            if (tiene4) return "Poker";
            if (tiene3 && cantidadPares == 1) return "Full";
            if (tiene3) return "Trio";
            if (cantidadPares >= 1) return "Par";

            return "Nada";
        }

        static int PuntajeBase(string[] mano)
        {
            int suma = 0;

            foreach (string carta in mano)
            {
                char rango = carta[0];

                switch (rango)
                {
                    case 'A': suma += 14; break;
                    case 'K': suma += 13; break;
                    case 'Q': suma += 12; break;
                    case 'J': suma += 11; break;
                    case 'T': suma += 10; break;
                    default:
                        suma += (int)char.GetNumericValue(rango);
                        break;
                }
            }

            return suma;
        }

        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Poker": return 4.0;
                case "Full": return 3.5;
                case "Trio": return 2.5;
                case "Par": return 1.5;
                default: return 1.0;
            }
        }

        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            if (x2)
            {
                puntaje *= 2;
            }

            if (mas10)
            {
                puntaje += 10;
            }

            return puntaje;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Mano: ");
            foreach (string carta in mano)
            {
                Console.Write($"[{carta}] ");
            }
            Console.WriteLine();

            Console.WriteLine($"Tipo de mano: {tipo}");
            Console.WriteLine($"Puntaje base: {basePts}");
            Console.WriteLine($"Multiplicador: x{mult:0.0}");
            Console.WriteLine($"Puntaje final: {total}");

            Console.ReadKey();
        }
    }
}
    

