using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[80, 6];

            // Rellenamos la matriz por defecto para que no tenga valores nulos
            for (int i = 0; i < 80; i++)
            {
                matriz[i, 0] = "";   // Nombre
                matriz[i, 1] = "";   // Apellido
                matriz[i, 2] = "0";  // Edad
                matriz[i, 3] = "";   // DNI
                matriz[i, 4] = "";   // Nacionalidad
                matriz[i, 5] = "NO"; // Ocupado
            }

            int opcion = 0;

            // Ciclo principal del menú
            while (opcion != 7)
            {
                Console.Clear();

                // Contamos asientos disponibles y ocupados recorriendo la columna 5 de la matriz
                int disponibles = 0;
                int ocupados = 0;
                for (int i = 0; i < 80; i++)
                {
                    if (matriz[i, 5] == "SI")
                    {
                        ocupados++;
                    }
                    else
                    {
                        disponibles++;
                    }
                }

                // Dibujamos el menú principal
                Console.WriteLine("==================================================");
                Console.WriteLine(" Menú Principal - AvengersAir: Buenos Aires a Wakanda");
                Console.WriteLine("==================================================");
                Console.WriteLine("Asientos Disponibles: " + disponibles);
                Console.WriteLine("Asientos Ocupados: " + ocupados);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine("6. Obtener Asientos con DNI Par");
                Console.WriteLine("7. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("\nIngrese la opción deseada: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // ==================== 1. VENDER ASIENTO ====================
                            Console.Clear();
                            Console.WriteLine("--- VENDER ASIENTO ---\n");
                            Console.WriteLine("N° Asiento\tTipo de Asiento");
                            Console.WriteLine("---------------------------------");

                            // Mostramos solo los libres
                            for (int i = 0; i < 80; i++)
                            {
                                if (matriz[i, 5] == "NO")
                                {
                                    int nroAsiento = i + 1;
                                    string tipo = "Económica";

                                    if (nroAsiento >= 1 && nroAsiento <= 20) tipo = "Primera Clase";
                                    else if (nroAsiento >= 40 && nroAsiento <= 43) tipo = "Salida de Emergencia";

                                    Console.WriteLine(nroAsiento + "\t\t" + tipo);
                                }
                            }

                            Console.Write("\nSeleccione el número de asiento a vender (1-80): ");
                            int nroVenta;
                            if (int.TryParse(Console.ReadLine(), out nroVenta) && nroVenta >= 1 && nroVenta <= 80)
                            {
                                int idx = nroVenta - 1;
                                if (matriz[idx, 5] == "SI")
                                {
                                    Console.WriteLine("\nEl asiento ya está ocupado.");
                                }
                                else
                                {
                                    Console.Write("Ingrese Nombre: ");
                                    matriz[idx, 0] = Console.ReadLine();

                                    Console.Write("Ingrese Apellido: ");
                                    matriz[idx, 1] = Console.ReadLine();

                                    Console.Write("Ingrese Edad: ");
                                    matriz[idx, 2] = Console.ReadLine();

                                    Console.Write("Ingrese DNI: ");
                                    matriz[idx, 3] = Console.ReadLine();

                                    Console.Write("Ingrese Nacionalidad: ");
                                    matriz[idx, 4] = Console.ReadLine();

                                    matriz[idx, 5] = "SI";
                                    Console.WriteLine("\n¡Venta registrada con éxito!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNúmero de asiento inválido.");
                            }
                            Console.WriteLine("\nPresione una tecla para volver...");
                            Console.ReadKey();
                            break;

                        case 2:
                            // ==================== 2. DEVOLVER ASIENTO ====================
                            Console.Clear();
                            Console.WriteLine("--- DEVOLVER ASIENTO ---\n");
                            Console.Write("Ingrese el número de asiento a devolver (1-80): ");
                            int nroDevolver;
                            if (int.TryParse(Console.ReadLine(), out nroDevolver) && nroDevolver >= 1 && nroDevolver <= 80)
                            {
                                int idx = nroDevolver - 1;
                                if (matriz[idx, 5] == "SI")
                                {
                                    // Limpiamos los datos del pasajero
                                    matriz[idx, 0] = "";
                                    matriz[idx, 1] = "";
                                    matriz[idx, 2] = "0";
                                    matriz[idx, 3] = "";
                                    matriz[idx, 4] = "";
                                    matriz[idx, 5] = "NO";
                                    Console.WriteLine("\nEl asiento ha sido liberado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("\nEl asiento ya está libre. No se realizó ninguna acción.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNúmero de asiento inválido.");
                            }
                            Console.WriteLine("\nPresione una tecla para volver...");
                            Console.ReadKey();
                            break;

                        case 3:
                            // ==================== 3. MODIFICAR ASIENTO ====================
                            Console.Clear();
                            Console.WriteLine("--- MODIFICAR ASIENTO ---\n");
                            Console.WriteLine("N° Asiento\tNombre\tApellido\tEdad\tDNI\tNacionalidad");
                            Console.WriteLine("--------------------------------------------------------------------------------");

                            bool hayOcupados = false;
                            for (int i = 0; i < 80; i++)
                            {
                                if (matriz[i, 5] == "SI")
                                {
                                    int nroAsiento = i + 1;
                                    Console.WriteLine(nroAsiento + "\t\t" + matriz[i, 0] + "\t" + matriz[i, 1] + "\t\t" + matriz[i, 2] + "\t" + matriz[i, 3] + "\t" + matriz[i, 4]);
                                    hayOcupados = true;
                                }
                            }

                            if (!hayOcupados)
                            {
                                Console.WriteLine("No hay asientos ocupados para modificar.");
                                Console.WriteLine("\nPresione una tecla para volver...");
                                Console.ReadKey();
                                break;
                            }

                            Console.Write("\nSeleccione el número de asiento a modificar: ");
                            int nroModificar;
                            if (int.TryParse(Console.ReadLine(), out nroModificar) && nroModificar >= 1 && nroModificar <= 80)
                            {
                                int idx = nroModificar - 1;
                                if (matriz[idx, 5] == "SI")
                                {
                                    Console.WriteLine("\nModificando (Deje vacío y presione Enter para no cambiar el dato actual):");

                                    Console.Write("Nombre actual (" + matriz[idx, 0] + "): ");
                                    string nuevoNom = Console.ReadLine();
                                    if (nuevoNom != "") matriz[idx, 0] = nuevoNom;

                                    Console.Write("Apellido actual (" + matriz[idx, 1] + "): ");
                                    string nuevoApe = Console.ReadLine();
                                    if (nuevoApe != "") matriz[idx, 1] = nuevoApe;

                                    Console.Write("Edad actual (" + matriz[idx, 2] + "): ");
                                    string nuevaEdad = Console.ReadLine();
                                    if (nuevaEdad != "") matriz[idx, 2] = nuevaEdad;

                                    Console.Write("DNI actual (" + matriz[idx, 3] + "): ");
                                    string nuevoDni = Console.ReadLine();
                                    if (nuevoDni != "") matriz[idx, 3] = nuevoDni;

                                    Console.Write("Nacionalidad actual (" + matriz[idx, 4] + "): ");
                                    string nuevaNac = Console.ReadLine();
                                    if (nuevaNac != "") matriz[idx, 4] = nuevaNac;

                                    Console.WriteLine("\n¡Datos modificados con éxito!");
                                }
                                else
                                {
                                    Console.WriteLine("\nEse asiento no está ocupado.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNúmero de asiento inválido.");
                            }
                            Console.WriteLine("\nPresione una tecla para volver...");
                            Console.ReadKey();
                            break;

                        case 4:
                            // ==================== 4. CALCULAR VENTAS ====================
                            Console.Clear();
                            Console.WriteLine("--- CALCULAR VENTAS ---\n");

                            int totalRecaudado = 0;
                            int cantPrimera = 0;
                            int cantEmergencia = 0;
                            int cantEconomica = 0;

                            for (int i = 0; i < 80; i++)
                            {
                                if (matriz[i, 5] == "SI")
                                {
                                    int nroAsiento = i + 1;
                                    if (nroAsiento >= 1 && nroAsiento <= 20)
                                    {
                                        totalRecaudado += 200;
                                        cantPrimera++;
                                    }
                                    else if (nroAsiento >= 40 && nroAsiento <= 43)
                                    {
                                        totalRecaudado += 80;
                                        cantEmergencia++;
                                    }
                                    else
                                    {
                                        totalRecaudado += 100;
                                        cantEconomica++;
                                    }
                                }
                            }

                            Console.WriteLine("Asientos Primera Clase ($200): " + cantPrimera);
                            Console.WriteLine("Asientos Emergencia ($80): " + cantEmergencia);
                            Console.WriteLine("Asientos Económica ($100): " + cantEconomica);
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Recaudación Total: $" + totalRecaudado);
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("\nPresione una tecla para volver...");
                            Console.ReadKey();
                            break;

                        case 5:
                            // ==================== 5. BUSCAR PASAJEROS POR EDAD ====================
                            Console.Clear();
                            Console.WriteLine("--- BUSCAR PASAJEROS POR EDAD ---\n");
                            Console.Write("Ingrese la edad a buscar: ");
                            string edadBuscar = Console.ReadLine();

                            Console.WriteLine("\nResultados:");
                            Console.WriteLine("N° Asiento\tNombre\tApellido\tDNI");
                            Console.WriteLine("---------------------------------------------");

                            bool encontradoEdad = false;
                            for (int i = 0; i < 80; i++)
                            {
                                if (matriz[i, 5] == "SI" && matriz[i, 2] == edadBuscar)
                                {
                                    int nroAsiento = i + 1;
                                    Console.WriteLine(nroAsiento + "\t\t" + matriz[i, 0] + "\t" + matriz[i, 1] + "\t\t" + matriz[i, 3]);
                                    encontradoEdad = true;
                                }
                            }

                            if (!encontradoEdad)
                            {
                                Console.WriteLine("No se encontraron pasajeros con esa edad.");
                            }
                            Console.WriteLine("\nPresione una tecla para volver...");
                            Console.ReadKey();
                            break;

                        case 6:
                            // ==================== 6. OBTENER ASIENTOS CON DNI PAR ====================
                            Console.Clear();
                            Console.WriteLine("--- ASIENTOS CON DNI PAR ---\n");
                            Console.WriteLine("N° Asiento\tNombre\tApellido\tDNI");
                            Console.WriteLine("---------------------------------------------");

                            bool encontradoPar = false;
                            for (int i = 0; i < 80; i++)
                            {
                                if (matriz[i, 5] == "SI")
                                {
                                    // Intentamos convertir el DNI que está en formato texto a número para saber si es par
                                    long dniNum;
                                    if (long.TryParse(matriz[i, 3], out dniNum))
                                    {
                                        if (dniNum % 2 == 0)
                                        {
                                            int nroAsiento = i + 1;
                                            Console.WriteLine(nroAsiento + "\t\t" + matriz[i, 0] + "\t" + matriz[i, 1] + "\t\t" + matriz[i, 3]);
                                            encontradoPar = true;
                                        }
                                    }
                                }
                            }

                            if (!encontradoPar)
                            {
                                Console.WriteLine("No se encontraron pasajeros con DNI par.");
                            }
                            Console.WriteLine("\nPresione una tecla para volver...");
                            Console.ReadKey();
                            break;

                        case 7:
                            Console.WriteLine("\n¡Gracias por usar el sistema de AvengersAir!");
                            break;

                        default:
                            Console.WriteLine("\nOpción inválida.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor, ingrese una opción numérica válida del 1 al 7.");
                    Console.ReadKey();
                }
            }
        }
    }

    
}
