using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        
        
namespace _13___PERO
    {
        class Program
        {
            static void Main(string[] args)
            {
                Random rand = new Random();

                // Matriz para guardar hasta 30 misiones (filas) y sus 5 datos (columnas)
                // Columnas: 
                // 0 = ID Misión (numérico, automático)
                // 1 = Mapa (1, 2 o 3)
                // 2 = Objetos a extraer (aleatorio entre 1 y 70)
                // 3 = Nivel de peligro (1 a 5)
                // 4 = Estado (0 = Pendiente, 1 = En curso, 2 = Finalizado)
                string[,] matriz = new string[30, 5];

                // Contador de misiones registradas actualmente
                int cantMisiones = 0;

                int opcion;
                do
                {
                    Console.Clear();
                    Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                    Console.WriteLine("1. Registrar nueva misión");
                    Console.WriteLine("2. Ver todas las misiones");
                    Console.WriteLine("3. Cambiar estado de una misión");
                    Console.WriteLine("4. Listar misiones en curso");
                    Console.WriteLine("5. Misión con más objetos a extraer");
                    Console.WriteLine("6. Promedio de pegrilo por mapa");
                    Console.WriteLine("7. Filtrar por mapa");
                    Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
    
                if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        opcion = 0; // Si ingresan letras, cae en el switch default
                    }

                    switch (opcion)
                    {
                        case 1:
                            // ==================== 1. REGISTRAR NUEVA MISIÓN ====================
                            Console.Clear();
                            Console.WriteLine("--- REGISTRAR NUEVA MISIÓN ---");

                            if (cantMisiones >= 30)
                            {
                                Console.WriteLine("\n¡Demasiadas misiones!");
                            }
                            else
                            {
                                // 1. ID automático consecutivo
                                int nuevoId = cantMisiones + 1;

                                // 2. Ingreso y validación de Mapa
                                int mapaElegido = 0;
                                bool mapaValido = false;
                                while (mapaValido == false)
                                {
                                    Console.WriteLine("\nMapas disponibles:");
                                    Console.WriteLine("1 = Hagwarts");
                                    Console.WriteLine("2 = La Casa del Viejo");
                                    Console.WriteLine("3 = El Laboratorio");
                                    Console.Write("Seleccione el número de mapa: ");

                                    if (int.TryParse(Console.ReadLine(), out mapaElegido) && mapaElegido >= 1 && mapaElegido <= 3)
                                    {
                                        mapaValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese mapa no es de este juegazo.");
                                    }
                                }

                                // 3. Objetos a extraer: Aleatorio entre 1 y 70
                                int objetos = rand.Next(1, 71);

                                // 4. Ingreso y validación de Nivel de Peligro
                                int peligro = 0;
                                bool peligroValido = false;
                                while (peligroValido == false)
                                {
                                    Console.Write("\nIngrese nivel de peligro (1 a 5): ");
                                    if (int.TryParse(Console.ReadLine(), out peligro) && peligro >= 1 && peligro <= 5)
                                    {
                                        peligroValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Este nivel es demasiado PEGRILOSO...");
                                    }
                                }

                                // Guardamos en la matriz en la posición actual de cantMisiones
                                matriz[cantMisiones, 0] = nuevoId.ToString();
                                matriz[cantMisiones, 1] = mapaElegido.ToString();
                                matriz[cantMisiones, 2] = objetos.ToString();
                                matriz[cantMisiones, 3] = peligro.ToString();
                                matriz[cantMisiones, 4] = "0"; // Inicialmente "0" (Pendiente)

                                cantMisiones++;
                                Console.WriteLine($"\n¡Misión registrada con éxito! ID asignado: {nuevoId}. Objetos a extraer calculados: {objetos}.");
                            }
                            break;

                        case 2:
                            // ==================== 2. VER TODAS LAS MISIONES ====================
                            Console.Clear();
                            Console.WriteLine("--- TODAS LAS MISIONES REGISTRADAS ---");

                            if (cantMisiones == 0)
                            {
                                Console.WriteLine("\nNo hay misiones registradas todavía.");
                            }
                            else
                            {
                                Console.WriteLine("\nID\t| Mapa\t\t\t| Objetos\t| Peligro\t| Estado");
                                Console.WriteLine("--------------------------------------------------------------------------------");
                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    // Traducir Mapa
                                    string nombreMapa = "";
                                    if (matriz[i, 1] == "1") nombreMapa = "Hagwarts";
                                    else if (matriz[i, 1] == "2") nombreMapa = "La Casa del Viejo";
                                    else if (matriz[i, 1] == "3") nombreMapa = "El Laboratorio";

                                    // Traducir Estado
                                    string descEstado = "";
                                    if (matriz[i, 4] == "0") descEstado = "Pendiente";
                                    else if (matriz[i, 4] == "1") descEstado = "En curso";
                                    else if (matriz[i, 4] == "2") descEstado = "Finalizado";

                                    Console.WriteLine(matriz[i, 0] + "\t| " + nombreMapa.PadRight(18) + "| " + matriz[i, 2] + "\t\t| " + matriz[i, 3] + "\t\t| " + descEstado);
                                }
                            }
                            break;

                        case 3:
                            // ==================== 3. CAMBIAR ESTADO DE MISIÓN ====================
                            Console.Clear();
                            Console.WriteLine("--- CAMBIAR ESTADO DE UNA MISIÓN ---");

                            if (cantMisiones == 0)
                            {
                                Console.WriteLine("\nNo hay misiones registradas.");
                            }
                            else
                            {
                                // Listamos todas las misiones para que el usuario elija de forma visual
                                Console.WriteLine("\nID\t| Mapa\t\t\t| Estado Actual");
                                Console.WriteLine("--------------------------------------------------");
                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    string nombreMapa = "";
                                    if (matriz[i, 1] == "1") nombreMapa = "Hagwarts";
                                    else if (matriz[i, 1] == "2") nombreMapa = "La Casa del Viejo";
                                    else if (matriz[i, 1] == "3") nombreMapa = "El Laboratorio";

                                    string descEstado = "";
                                    if (matriz[i, 4] == "0") descEstado = "Pendiente";
                                    else if (matriz[i, 4] == "1") descEstado = "En curso";
                                    else if (matriz[i, 4] == "2") descEstado = "Finalizado";

                                    Console.WriteLine(matriz[i, 0] + "\t| " + nombreMapa.PadRight(18) + "| " + descEstado);
                                }

                                Console.Write("\nIngrese el ID de la misión para cambiar de estado: ");
                                int idBuscar;
                                if (int.TryParse(Console.ReadLine(), out idBuscar))
                                {
                                    bool encontrado = false;
                                    for (int i = 0; i < cantMisiones; i++)
                                    {
                                        if (matriz[i, 0] == idBuscar.ToString())
                                        {
                                            encontrado = true;
                                            int estadoActual = int.Parse(matriz[i, 4]);

                                            if (estadoActual == 0)
                                            {
                                                matriz[i, 4] = "1"; // Avanza a En curso de forma automática
                                                Console.WriteLine($"\n¡La misión {idBuscar} cambió automáticamente a 'En curso'!");
                                            }
                                            else if (estadoActual == 1)
                                            {
                                                matriz[i, 4] = "2"; // Avanza a Finalizado de forma automática
                                                Console.WriteLine($"\n¡La misión {idBuscar} cambió automáticamente a 'Finalizado'!");
                                            }
                                            else if (estadoActual == 2)
                                            {
                                                Console.WriteLine("\nEsta misión ya está finalizada y no puede avanzar más de estado.");
                                            }
                                            break;
                                        }
                                    }
                                    if (encontrado == false)
                                    {
                                        Console.WriteLine("\nNo se encontró ninguna misión con ese ID.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nID ingresado inválido.");
                                }
                            }
                            break;

                        case 4:
                            // ==================== 4. LISTAR MISIONES EN CURSO ====================
                            Console.Clear();
                            Console.WriteLine("--- MISIONES EN CURSO ---");

                            if (cantMisiones == 0)
                            {
                                Console.WriteLine("\nNo hay misiones registradas.");
                            }
                            else
                            {
                                Console.WriteLine("\nID\t| Mapa\t\t\t| Objetos\t| Peligro");
                                Console.WriteLine("--------------------------------------------------------------------------------");

                                bool hayEnCurso = false;
                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    if (matriz[i, 4] == "1") // 1 = En curso
                                    {
                                        string nombreMapa = "";
                                        if (matriz[i, 1] == "1") nombreMapa = "Hagwarts";
                                        else if (matriz[i, 1] == "2") nombreMapa = "La Casa del Viejo";
                                        else if (matriz[i, 1] == "3") nombreMapa = "El Laboratorio";

                                        Console.WriteLine(matriz[i, 0] + "\t| " + nombreMapa.PadRight(18) + "| " + matriz[i, 2] + "\t\t| " + matriz[i, 3]);
                                        hayEnCurso = true;
                                    }
                                }

                                if (hayEnCurso == false)
                                {
                                    Console.WriteLine("No hay misiones activas 'En curso' actualmente.");
                                }
                            }
                            break;

                        case 5:
                            // ==================== 5. MISIÓN CARGADITA ====================
                            Console.Clear();
                            Console.WriteLine("--- MISIÓN CARGADITA ---");

                            if (cantMisiones == 0)
                            {
                                Console.WriteLine("\nNo hay misiones registradas.");
                            }
                            else
                            {
                                // Buscamos el valor máximo de objetos recorriendo la matriz
                                int maxObjetos = 0;
                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    int objActual = int.Parse(matriz[i, 2]);
                                    if (objActual > maxObjetos)
                                    {
                                        maxObjetos = objActual;
                                    }
                                }

                                Console.WriteLine($"\nLa mayor cantidad de objetos a extraer es: {maxObjetos}");
                                Console.WriteLine("\nMisiones con esta cantidad:");
                                Console.WriteLine("\nID\t| Mapa\t\t\t| Peligro\t| Estado");
                                Console.WriteLine("--------------------------------------------------------------------------------");

                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    if (int.Parse(matriz[i, 2]) == maxObjetos)
                                    {
                                        string nombreMapa = "";
                                        if (matriz[i, 1] == "1") nombreMapa = "Hagwarts";
                                        else if (matriz[i, 1] == "2") nombreMapa = "La Casa del Viejo";
                                        else if (matriz[i, 1] == "3") nombreMapa = "El Laboratorio";

                                        string descEstado = "";
                                        if (matriz[i, 4] == "0") descEstado = "Pendiente";
                                        else if (matriz[i, 4] == "1") descEstado = "En curso";
                                        else if (matriz[i, 4] == "2") descEstado = "Finalizado";

                                        Console.WriteLine(matriz[i, 0] + "\t| " + nombreMapa.PadRight(18) + "| " + matriz[i, 3] + "\t\t| " + descEstado);
                                    }
                                }
                            }
                            break;

                        case 6:
                            // ==================== 6. PROMEDIO DE PELIGRO POR MAPA ====================
                            Console.Clear();
                            Console.WriteLine("--- PROMEDIO DE PEGRILO POR MAPA ---");

                            if (cantMisiones == 0)
                            {
                                Console.WriteLine("\nNo hay misiones registradas.");
                            }
                            else
                            {
                                // Acumuladores y contadores individuales para no usar listas ni funciones
                                int sumaMap1 = 0, cantMap1 = 0;
                                int sumaMap2 = 0, cantMap2 = 0;
                                int sumaMap3 = 0, cantMap3 = 0;

                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    int mapa = int.Parse(matriz[i, 1]);
                                    int peligro = int.Parse(matriz[i, 3]);

                                    if (mapa == 1)
                                    {
                                        sumaMap1 += peligro;
                                        cantMap1++;
                                    }
                                    else if (mapa == 2)
                                    {
                                        sumaMap2 += peligro;
                                        cantMap2++;
                                    }
                                    else if (mapa == 3)
                                    {
                                        sumaMap3 += peligro;
                                        cantMap3++;
                                    }
                                }

                                Console.WriteLine("\nPromedios calculados:");
                                Console.WriteLine("-----------------------------------------");

                                if (cantMap1 > 0)
                                    Console.WriteLine("1. Hagwarts: " + ((double)sumaMap1 / cantMap1).ToString("0.00"));
                                else
                                    Console.WriteLine("1. Hagwarts: Sin misiones registradas.");

                                if (cantMap2 > 0)
                                    Console.WriteLine("2. La Casa del Viejo: " + ((double)sumaMap2 / cantMap2).ToString("0.00"));
                                else
                                    Console.WriteLine("2. La Casa del Viejo: Sin misiones registradas.");

                                if (cantMap3 > 0)
                                    Console.WriteLine("3. El Laboratorio: " + ((double)sumaMap3 / cantMap3).ToString("0.00"));
                                else
                                    Console.WriteLine("3. El Laboratorio: Sin misiones registradas.");
                                Console.WriteLine("-----------------------------------------");
                            }
                            break;

                        case 7:
                            // ==================== 7. FILTRAR POR MAPA ====================
                            Console.Clear();
                            Console.WriteLine("--- FILTRAR POR MAPA ---");

                            if (cantMisiones == 0)
                            {
                                Console.WriteLine("\nNo hay misiones registradas.");
                            }
                            else
                            {
                                int mapaFiltrar = 0;
                                bool mapaValido = false;
                                while (mapaValido == false)
                                {
                                    Console.WriteLine("\nIngrese el mapa por el cual filtrar (1 a 3):");
                                    Console.WriteLine("1 = Hagwarts");
                                    Console.WriteLine("2 = La Casa del Viejo");
                                    Console.WriteLine("3 = El Laboratorio");
                                    Console.Write("Opción: ");

                                    if (int.TryParse(Console.ReadLine(), out mapaFiltrar) && mapaFiltrar >= 1 && mapaFiltrar <= 3)
                                    {
                                        mapaValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ese mapa no es de este juegazo.");
                                    }
                                }

                                Console.Clear();
                                Console.WriteLine($"--- MISIONES EN EL MAPA {mapaFiltrar} ---");
                                Console.WriteLine("\nID\t| Objetos\t| Peligro\t| Estado");
                                Console.WriteLine("--------------------------------------------------------------------------------");

                                bool hayMisionesMapa = false;
                                for (int i = 0; i < cantMisiones; i++)
                                {
                                    if (int.Parse(matriz[i, 1]) == mapaFiltrar)
                                    {
                                        string descEstado = "";
                                        if (matriz[i, 4] == "0") descEstado = "Pendiente";
                                        else if (matriz[i, 4] == "1") descEstado = "En curso";
                                        else if (matriz[i, 4] == "2") descEstado = "Finalizado";

                                        Console.WriteLine(matriz[i, 0] + "\t| " + matriz[i, 2] + "\t\t| " + matriz[i, 3] + "\t\t| " + descEstado);
                                        hayMisionesMapa = true;
                                    }
                                }

                                if (hayMisionesMapa == false)
                                {
                                    Console.WriteLine("No se encontraron misiones registradas en este mapa.");
                                }
                            }
                            break;

                        case 8:
                            Console.WriteLine("\nSaliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                            break;
                    }

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                } while (opcion != 8);
            }
        }
    }




    

