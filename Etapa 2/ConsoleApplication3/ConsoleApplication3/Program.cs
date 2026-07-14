using System;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 50000;
            int opcion = 0;
            int deposito;
            int retiro;
            do
            {
                Console.WriteLine("menu del cajero");
                Console.WriteLine("1. consultar saldo");
                Console.WriteLine("2. depositar dinero");
                Console.WriteLine("3. retirar dinero");
                Console.WriteLine("4. salir");

                opcion = int.Parse(Console.ReadLine());

                if (opcion != 4)
                {
                    switch (opcion)
                    {
                        case 1:Console.WriteLine("su saldo actual es: $" + saldo);
                            break;
                        case 2:
                            Console.WriteLine("ingrese el monto deseado a depositar");
                            deposito = int.Parse(Console.ReadLine());
                            
                            if (deposito < 0)
                                Console.WriteLine("monto invalido");
                            else
                                saldo = saldo + deposito;
                                Console.WriteLine("deposito exitoso");
                            break;

                        case 3: Console.WriteLine("ingrese un monto a retirar");
                            retiro = int.Parse(Console.ReadLine());
                            if (retiro == 0)
                            { Console.WriteLine("monto invalido"); }
                            else
                                if (retiro > saldo)
                            { Console.WriteLine("fondos insuficientes"); }
                            else
                                if (retiro % 1000 == 0)
                            {
                                saldo = saldo -retiro;
                                Console.WriteLine("retiro permitido");
                            }
                            else
                                Console.WriteLine("solo se puede retirar en multiplos de 1000");
                            break;
                        case 4: Console.WriteLine("gracias por usar el cajero");
                            break;
                        default: Console.WriteLine("opcion invalida");
                            break;
                    }
                }
            }
            while (opcion != 4);
            Console.WriteLine("gracias por usar el cajero");
            Console.ReadKey();
        }
    }
}
