using System;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidadMaxima = 20;
            int vehiculosEstacionados = 0;
            int costoEstacionamiento = 2500;
            int recaudacionTotal = 0;
            int opcion = 0;

            do
            {
                Console.WriteLine("1 - Ingresar vehículo");
                Console.WriteLine("2 - Retirar vehículo");
                Console.WriteLine("3 - Consultar estado");
                Console.WriteLine("4 - Cerrar caja y salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        if (vehiculosEstacionados == capacidadMaxima)
                        {
                            Console.WriteLine("Estacionamiento lleno");
                        }
                        else
                        {
                            vehiculosEstacionados++;

                            Console.WriteLine("Vehículo ingresado.");
                            Console.WriteLine("Cupos restantes: " + (capacidadMaxima - vehiculosEstacionados));
                        }

                        break;

                    case 2:

                        if (vehiculosEstacionados == 0)
                        {
                            Console.WriteLine("Error: el estacionamiento está vacío");
                        }
                        else
                        {
                            int pago = 0;

                            while (pago < costoEstacionamiento)
                            {
                                Console.Write("Ingrese el monto pagado: $");
                                pago = int.Parse(Console.ReadLine());

                                if (pago < costoEstacionamiento)
                                {
                                    Console.WriteLine("Pago insuficiente");
                                }
                            }

                            int vuelto = pago - costoEstacionamiento;

                            Console.WriteLine("Salida registrada.");
                            Console.WriteLine("Su vuelto es: $" + vuelto);

                            vehiculosEstacionados--;

                            recaudacionTotal += costoEstacionamiento;
                        }

                        break;

                    case 3:

                        Console.WriteLine("Vehículos presentes: " + vehiculosEstacionados + "/20");
                        Console.WriteLine("Dinero en caja: $" + recaudacionTotal);

                        break;

                    case 4:

                        Console.Write("Ingrese clave de administrador: ");
                        int clave = int.Parse(Console.ReadLine());

                        if (clave == 1234)
                        {
                            Console.WriteLine("Caja cerrada.");
                            Console.WriteLine("Total del día: $" + recaudacionTotal);
                            Console.WriteLine("Vehículos restantes en el estacionamiento: " + vehiculosEstacionados);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Acceso denegado");
                            opcion = 0;
                        }

                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (opcion != 4);
        }
          
    }




}
    