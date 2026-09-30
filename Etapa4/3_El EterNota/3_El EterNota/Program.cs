using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_El_EterNota
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codRefugio = new int[20];
            int[] capacidadMaxima = new int[20];
            int[] suministrosDisponibles = new int[20];
            int[] zona = new int[20];
            int[] ocupado = new int[20];

            int cantidadRefugios = 0;
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("=== El EterNota - Gestión de Refugios ===");
                Console.WriteLine("1. Agregar nuevo refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar un refugio");
                Console.WriteLine("4. Listar todos los refugios ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio de capacidad por zona");
                Console.WriteLine("7. Filtrar refugios por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            if (cantidadRefugios >= 20)
                            {
                                Console.WriteLine("No hay refugios... ¡Vamos a morir!");
                                break;
                            }

                            int nuevoCod = 0;
                            bool codValido = false;
                            while (!codValido)
                            {
                                Console.Write("Ingrese el Código del refugio: ");
                                if (int.TryParse(Console.ReadLine(), out nuevoCod))
                                {
                                    bool existe = false;
                                    for (int i = 0; i < cantidadRefugios; i++)
                                    {
                                        if (codRefugio[i] == nuevoCod)
                                        {
                                            existe = true;
                                            break;
                                        }
                                    }

                                    if (existe)
                                    {
                                        Console.WriteLine("El código ya existe. Ingrese otro.");
                                    }
                                    else
                                    {
                                        codValido = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No se puede sobrevivir debiendo...");
                                }
                            }

                            int nuevaCap = 0;
                            bool capValida = false;
                            while (!capValida)
                            {
                                Console.Write("Ingrese la Capacidad Máxima: ");
                                if (int.TryParse(Console.ReadLine(), out nuevaCap) && nuevaCap > 0)
                                {
                                    capValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("No se puede sobrevivir debiendo...");
                                }
                            }

                            int nuevoSum = 0;
                            bool sumValido = false;
                            while (!sumValido)
                            {
                                Console.Write("Ingrese la cantidad de Suministros Disponibles: ");
                                if (int.TryParse(Console.ReadLine(), out nuevoSum) && nuevoSum > 0)
                                {
                                    sumValido = true;
                                }
                                else
                                {
                                    Console.WriteLine("No se puede sobrevivir debiendo...");
                                }
                            }

                            int nuevaZona = 0;
                            bool zonaValida = false;
                            while (!zonaValida)
                            {
                                Console.WriteLine("Seleccione la Zona:");
                                Console.WriteLine("1 = NORTE (Congreso)");
                                Console.WriteLine("2 = SUR (Constitución)");
                                Console.WriteLine("3 = OESTE (Flores)");
                                Console.WriteLine("4 = CENTRO (Microcentro)");
                                Console.Write("Opción (1-4): ");

                                if (int.TryParse(Console.ReadLine(), out nuevaZona) && nuevaZona >= 1 && nuevaZona <= 4)
                                {
                                    zonaValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("Zona inválida, esa parte ya está perdida");
                                }
                            }

                            int nuevoOcupado = 0;
                            bool ocupadoValido = false;
                            while (!ocupadoValido)
                            {
                                Console.Write("¿Está ocupado actualmente? (1 = SÍ / 0 = NO): ");
                                if (int.TryParse(Console.ReadLine(), out nuevoOcupado) && (nuevoOcupado == 0 || nuevoOcupado == 1))
                                {
                                    ocupadoValido = true;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese 1 para SÍ o 0 para NO.");
                                }
                            }

                            codRefugio[cantidadRefugios] = nuevoCod;
                            capacidadMaxima[cantidadRefugios] = nuevaCap;
                            suministrosDisponibles[cantidadRefugios] = nuevoSum;
                            zona[cantidadRefugios] = nuevaZona;
                            ocupado[cantidadRefugios] = nuevoOcupado;

                            cantidadRefugios++;
                            Console.WriteLine("\n¡Refugio registrado exitosamente!");
                            break;

                        case 2:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("No hay refugios registrados.");
                                break;
                            }

                            Console.WriteLine("=== LISTA DE REFUGIOS ===");
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                Console.WriteLine("Código: " + codRefugio[i]);
                                Console.WriteLine("Capacidad Máxima: " + capacidadMaxima[i]);
                                Console.WriteLine("Suministros: " + suministrosDisponibles[i]);
                                Console.WriteLine("Zona: " + ObtenerNombreZona(zona[i]));
                                Console.WriteLine("Estado: " + (ocupado[i] == 1 ? "Ocupado" : "Libre"));
                                Console.WriteLine("--------------------------------");
                            }
                            break;

                        case 3:
                            bool hayLibres = false;
                            Console.WriteLine("=== REFUGIOS NO OCUPADOS ===");
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (ocupado[i] == 0)
                                {
                                    Console.WriteLine("Código: " + codRefugio[i] + " | Capacidad: " + capacidadMaxima[i] + " | Zona: " + ObtenerNombreZona(zona[i]));
                                    hayLibres = true;
                                }
                            }

                            if (!hayLibres)
                            {
                                Console.WriteLine("No hay refugios disponibles para ocupar.");
                                break;
                            }

                            Console.Write("Ingrese el Código del refugio que desea ocupar: ");
                            int codBuscado;
                            if (int.TryParse(Console.ReadLine(), out codBuscado))
                            {
                                int indice = -1;
                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (codRefugio[i] == codBuscado)
                                    {
                                        indice = i;
                                        break;
                                    }
                                }

                                if (indice != -1)
                                {
                                    if (ocupado[indice] == 1)
                                    {
                                        Console.WriteLine("No somos Okupas, este ya está ocupado");
                                    }
                                    else
                                    {
                                        ocupado[indice] = 1;
                                        Console.WriteLine("El refugio ha sido marcado como OCUPADO.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El código de refugio ingresado no existe.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Código inválido.");
                            }
                            break;

                        case 4:
                            bool hayOcupados = false;
                            Console.WriteLine("=== REFUGIOS OCUPADOS ===");
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (ocupado[i] == 1)
                                {
                                    Console.WriteLine("Código: " + codRefugio[i]);
                                    Console.WriteLine("Capacidad Máxima: " + capacidadMaxima[i]);
                                    Console.WriteLine("Suministros: " + suministrosDisponibles[i]);
                                    Console.WriteLine("Zona: " + ObtenerNombreZona(zona[i]));
                                    Console.WriteLine("--------------------------------");
                                    hayOcupados = true;
                                }
                            }

                            if (!hayOcupados)
                            {
                                Console.WriteLine("No hay refugios ocupados actualmente.");
                            }
                            break;

                        case 5:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("No hay refugios registrados.");
                                break;
                            }

                            int maxSuministros = suministrosDisponibles[0];
                            for (int i = 1; i < cantidadRefugios; i++)
                            {
                                if (suministrosDisponibles[i] > maxSuministros)
                                {
                                    maxSuministros = suministrosDisponibles[i];
                                }
                            }

                            int contadorMaximos = 0;
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (suministrosDisponibles[i] == maxSuministros)
                                {
                                    contadorMaximos++;
                                }
                            }

                            Console.WriteLine("=== REFUGIO(S) CON MÁS SUMINISTROS ===");
                            if (contadorMaximos > 1)
                            {
                                Console.WriteLine("Aclaración: Existen varios refugios que comparten la cantidad máxima de suministros (" + maxSuministros + ").\n");
                            }

                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (suministrosDisponibles[i] == maxSuministros)
                                {
                                    Console.WriteLine("Código: " + codRefugio[i]);
                                    Console.WriteLine("Capacidad Máxima: " + capacidadMaxima[i]);
                                    Console.WriteLine("Suministros: " + suministrosDisponibles[i]);
                                    Console.WriteLine("Zona: " + ObtenerNombreZona(zona[i]));
                                    Console.WriteLine("Estado: " + (ocupado[i] == 1 ? "Ocupado" : "Libre"));
                                    Console.WriteLine("--------------------------------");
                                }
                            }
                            break;

                        case 6:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("No hay refugios registrados.");
                                break;
                            }

                            Console.WriteLine("=== PROMEDIO DE CAPACIDAD POR ZONA ===");

                            for (int z = 1; z <= 4; z++)
                            {
                                int sumaCapacidad = 0;
                                int contadorZona = 0;

                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (zona[i] == z)
                                    {
                                        sumaCapacidad += capacidadMaxima[i];
                                        contadorZona++;
                                    }
                                }

                                string nombreZona = ObtenerNombreZona(z);
                                if (contadorZona > 0)
                                {
                                    double promedio = (double)sumaCapacidad / contadorZona;
                                    Console.WriteLine("Zona " + nombreZona + ": " + promedio.ToString("0.00") + " personas de promedio.");
                                }
                                else
                                {
                                    Console.WriteLine("Zona " + nombreZona + ": Sin refugios registrados.");
                                }
                            }
                            break;

                        case 7:
                            if (cantidadRefugios == 0)
                            {
                                Console.WriteLine("No hay refugios registrados.");
                                break;
                            }

                            Console.WriteLine("Ingrese la zona a consultar:");
                            Console.WriteLine("1 = NORTE (Congreso)");
                            Console.WriteLine("2 = SUR (Constitución)");
                            Console.WriteLine("3 = OESTE (Flores)");
                            Console.WriteLine("4 = CENTRO (Microcentro)");
                            Console.Write("Zona: ");

                            int zonaBuscada;
                            if (int.TryParse(Console.ReadLine(), out zonaBuscada) && zonaBuscada >= 1 && zonaBuscada <= 4)
                            {
                                bool encontrado = false;
                                Console.WriteLine("\n=== REFUGIOS EN ZONA " + ObtenerNombreZona(zonaBuscada) + " ===");

                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (zona[i] == zonaBuscada)
                                    {
                                        Console.WriteLine("Código: " + codRefugio[i]);
                                        Console.WriteLine("Capacidad Máxima: " + capacidadMaxima[i]);
                                        Console.WriteLine("Suministros: " + suministrosDisponibles[i]);
                                        Console.WriteLine("Estado: " + (ocupado[i] == 1 ? "Ocupado" : "Libre"));
                                        Console.WriteLine("--------------------------------");
                                        encontrado = true;
                                    }
                                }

                                if (!encontrado)
                                {
                                    Console.WriteLine("No hay refugios registrados en esta zona.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Zona inválida, esa parte ya está perdida");
                            }
                            break;

                        case 8:
                            Console.WriteLine("Saliendo del sistema...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                if (opcion != 8)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 8);
        }

        static string ObtenerNombreZona(int z)
        {
            switch (z)
            {
                case 1: return "NORTE (Congreso)";
                case 2: return "SUR (Constitución)";
                case 3: return "OESTE (Flores)";
                case 4: return "CENTRO (Microcentro)";
                default: return "Desconocida";
            }
        }
    }
}
    

