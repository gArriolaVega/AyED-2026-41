using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimualdorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int vida = 10;
                int hambre = 10;
                int dia = 0;
                int comida_cruda = 0;
                int comida_cocida = 0;
                bool refugio = false;
                bool fogata = false;
                Random azar = new Random();
                bool juego_activo = true;
                while (juego_activo)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Día {dia} | Vida: {vida} | Hambre: {hambre}");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Cruda: {comida_cruda} | Cocida: {comida_cocida}");
                    Console.WriteLine($"Refugio: {refugio} | Fogata: {fogata}");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Buscar comida");
                    Console.WriteLine("2.Explorar");
                    Console.WriteLine("3.Construir refugio");
                    Console.WriteLine("4.Encender fogata");
                    Console.WriteLine("5.Cocinar");
                    Console.WriteLine("6.Comer");
                    Console.WriteLine("7.Descansar");
                    Console.WriteLine("8.Salir");
                    Console.WriteLine(" ");
                    int opcion = int.Parse(Console.ReadLine());
                    bool accion_valida = false;
                    switch (opcion)
                    {
                        case 1:
                            int random_encontrar = azar.Next(1, 101);
                            if (random_encontrar <= 60)
                            {
                                comida_cruda += 2;
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Bien ahi cazaste para tu comida ( esta cruda ) ");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Te dio paja y no hiciste nada en la tarde");
                                Console.WriteLine("-----------------------------------------------------------");
                            }

                            accion_valida = true;

                            break;

                        case 2:

                            int random_explorar = azar.Next(1, 101);
                            if (random_explorar <= 50)
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Encontraste muchos materiales");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;
                            }
                            else if (random_explorar <= 80)
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Encontraste pura mielda");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;
                            }
                            else
                            {

                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Te cruzaste un bicho y te cagaste todo");
                                Console.WriteLine("-----------------------------------------------------------");
                                vida -= 2;
                                accion_valida = true;
                            }
                            break;
                        case 3:
                            if (!refugio)
                            {
                                refugio = true;
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Hiciste tu mansion de palitos ");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Para que queres otra casa ");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            break;
                        case 4:
                            if (refugio)
                            {
                                fogata = true;
                                Console.Clear();
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("Oa hiciste fuego.");
                                Console.WriteLine("---------------------------------------------------------------------");
                                accion_valida = true;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Hacete una casita para hcer la fogata ");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            break;
                        case 5:
                            if (comida_cruda > 0 && fogata)
                            {
                                comida_cruda--;
                                comida_cocida++;
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine(" cocicicnaste algo Gordon Ramsay");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine(" Hace la fogata maestro.");
                                Console.WriteLine("-----------------------------------------------------------");
                            }

                            break;
                        case 6:
                            if (comida_cocida > 0)
                            {
                                comida_cocida--;
                                hambre += 8;

                                if (hambre > 10)
                                    hambre = 10;

                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Comiste.");
                                Console.WriteLine("-----------------------------------------------------------");
                                accion_valida = true;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------");
                                Console.WriteLine("Cocina o queres comer vena cruda.");
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            break;
                        case 7:
                            if (refugio)
                            {
                                vida += 3;
                            }
                            else
                            {
                                vida += 1;
                            }

                            if (vida > 10)
                                vida = 10;
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("Doriste 10 horas");
                            Console.WriteLine("-----------------------------------------------------------");
                            accion_valida = true;
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("Saliste del juego.");
                            Console.WriteLine("-----------------------------------------------------------");
                            juego_activo = false;
                            continue;
                    }
                    if (accion_valida)
                    {
                        dia++;
                        hambre = hambre - 2;
                    }
                    if (hambre < 0)

                    { hambre = 0; }

                    if (hambre == 0)
                    {
                       vida = vida - 2;
                    }
                    if (vida <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine($"            La quedaste mal ahi sobreviviste {dia} dia                  ");
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.ReadKey();
                        juego_activo = false;
                    }



                }

            }
        }
    }

}
    

