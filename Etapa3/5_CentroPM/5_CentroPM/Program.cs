using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vida = new int [6];
            int contador = 0;
            Random azar = new Random();
            bool juego = true;
            while (juego) 
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("1.Registrar nuevo Pokemon: ");
                Console.WriteLine("2.Mostrar vida de todos los Pokemons: ");
                Console.WriteLine("3.Curar un Pokemon: ");
                Console.WriteLine("4.Dañar un Pokemon: ");
                Console.WriteLine("5.Curar a todos los Pokemons: ");
                Console.WriteLine("6.Mostrar Pokemons debilitados: ");
                Console.WriteLine("7.Mostrar Pokemon con mayor vida: ");
                Console.WriteLine("8.Mostrar Pokemon con menor vida: ");
                Console.WriteLine("9.Calcular el promedio de vida del equipo: ");
                Console.WriteLine("10.Ordenar Pokemons por vida de mayor a menor: ");
                Console.WriteLine("11.Ordenar Pokemons por vida de menor a mayor: ");
                Console.WriteLine("12.Simular ataque enemigo al equipo: ");
                Console.WriteLine("13.Salir: ");
                Console.WriteLine(" ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (contador < 6)
                        {
                            Console.WriteLine("Registre su Pokemon nuevo con vida del 1-100 ");
                            int salud = int.Parse(Console.ReadLine());
                            if (salud >= 1 && salud <= 100)
                            {
                                vida[contador] = salud;
                                contador++;
                                Console.WriteLine("Carga completa correctamente ");
                            }
                            else
                            {
                                Console.WriteLine("Invalido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Los 6 Pokemons fueron caragdos");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Tu equipo" );
                        Console.WriteLine(" ");
                        for (int i = 0; i < vida.Length; i++)
                        {
                            Console.WriteLine($"Pokemon {i}: {vida[i]}");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Elige un pokemon: ");
                        int pokemon_elegido1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Cantidad de vida: ");
                        int cantidad_vida = int.Parse(Console.ReadLine());
                        vida[pokemon_elegido1] += cantidad_vida;

                        if (vida[pokemon_elegido1] > 100)
                        { vida[pokemon_elegido1] = 100; }
                        Console.Clear();
                        Console.WriteLine($"La vida de  { pokemon_elegido1} es de { vida[pokemon_elegido1]}");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Elige un pokemon: ");
                        int pokemon_elegido2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Cuanta vida queres sacarle: ");
                        int cantidad_vida2 = int.Parse(Console.ReadLine());

                        vida[pokemon_elegido2] -= cantidad_vida2;
                        if (vida[pokemon_elegido2] < 0)
                        { vida[pokemon_elegido2] = 0; }
                        Console.Clear();
                        Console.WriteLine($"L vida de {pokemon_elegido2} es de { vida[pokemon_elegido2]}");
                        Console.WriteLine(" ");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine($"Cuanta vida queres agregar: ");
                        int agregar_vida = int.Parse(Console.ReadLine());

                        for (int i = 0; i < vida.Length; i++)
                        {
                            vida[i] += agregar_vida;
                            if (vida[i] > 100)
                            {
                                vida[i] = 100;
                            }

                        }
                        break;

                    case 6:
                        Console.Clear();
                        for ( int i = 0; i < vida.Length; i++)
                        {
                            if (vida[i] == 0)
                            {
                                Console.WriteLine($"La posicion {i} es de 0");

                            }
                        }
                        break;

                    case 7:
                        Console.Clear();
                        Array.Sort(vida);
                        Array.Reverse(vida);
                        Console.Write($"{vida[0]}");
                        break;

                    case 8:
                        Console.Clear();
                        Array.Sort(vida);
                        Console.Write($"{vida[0]}");
                        break;

                    case 9:
                        Console.Clear();
                        int suma = 0;
                        for (int i = 0; i < vida.Length; i++)
                        {
                            suma += vida[i];
                        }
                        double promedio = (double)suma / vida.Length;
                        Console.Write(promedio);
                        break;

                    case 10:
                        Console.Clear();
                        for (int i = 0; i < vida.Length; i++)
                        {
                            Console.Write("");
                            Console.Write($"{vida[i]}");
                        }
                        break;

                    case 11:
                        Console.Clear();
                        Array.Sort(vida);
                        Console.WriteLine(string.Join(",", vida));
                        break;

                    case 12:
                        Console.Clear();
                        Array.Sort(vida);
                        Array.Reverse(vida);
                        Console.WriteLine(string.Join(",", vida));
                        break;

                    case 13:
                        juego = false;
                        break;
                    default:
                        break;













                }


            }


        }
    }
}
