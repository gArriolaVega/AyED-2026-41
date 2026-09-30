using System;

class Cuenta
{
    private int numero;
    private double saldo;

    public Cuenta(int numero)
    {
        this.numero = numero;
        saldo = 0;
    }

    public int ObtenerNumero()
    {
        return numero;
    }

    public double ObtenerSaldo()
    {
        return saldo;
    }

    public string ObtenerSaldoMoneda()
    {
        return saldo.ToString("C");
    }

    public void Depositar(double cantidad)
    {
        saldo = saldo + cantidad;

        Console.WriteLine("deposito realizado");
        Console.WriteLine("se depositaron: " + cantidad);
    }

    public void Retirar(double cantidad)
    {
        if (cantidad <= saldo)
        {
            saldo = saldo - cantidad;

            Console.WriteLine("retiro realizado");
            Console.WriteLine("se retiraron: " + cantidad);
        }
        else
        {
            Console.WriteLine("no tiene saldo suficiente");
        }
    }

    public void ImprimirSaldo()
    {
        Console.WriteLine("saldo actual: " + ObtenerSaldoMoneda());
    }
}

class Program
{
    static void Main()
    {
        Console.Write("ingrese el numero de cuenta: ");
        int numero = int.Parse(Console.ReadLine());

        Cuenta cuenta = new Cuenta(numero);

        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine();
            Console.WriteLine("cuenta numero: " + cuenta.ObtenerNumero());
            Console.WriteLine("1. depositar");
            Console.WriteLine("2. retirar");
            Console.WriteLine("3. mostrar saldo");
            Console.WriteLine("4. salir");

            Console.Write("ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("ingrese la cantidad a depositar: ");
                double cantidad = double.Parse(Console.ReadLine());

                cuenta.Depositar(cantidad);
            }

            if (opcion == 2)
            {
                Console.Write("ingrese la cantidad a retirar: ");
                double cantidad = double.Parse(Console.ReadLine());

                cuenta.Retirar(cantidad);
            }

            if (opcion == 3)
            {
                cuenta.ImprimirSaldo();
            }
        }

        Console.ReadKey();
    }
}