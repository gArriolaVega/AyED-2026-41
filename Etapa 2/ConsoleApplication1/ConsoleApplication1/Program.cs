using System;

class Program
{
    static void Main()
    {
        double monto;
        double billete;
        Console.WriteLine("Ingrese un monto a pagar: ");
        monto= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese un billete con el que pagar: ");
        billete = Convert.ToDouble(Console.ReadLine());
        if (billete < monto)
        {
            Console.WriteLine("error: dinero insuficiente");
        }
        else
        {
            double vuelto = billete - monto;
            Console.WriteLine("Vuelto: " + vuelto);

            int restante = (int)vuelto;
            int b10000 = 10000, b2000 = 2000, b1000 = 1000, b500 = 500, b200 = 200, b100 = 100, b50 = 50, b20 = 20, b10 = 10;
            if (restante >= 10000)
            {
                int cant = restante / b10000;
                Console.WriteLine("10000 x " + cant);
                restante = restante - (cant * b10000);
            }

            if (restante >= b2000)
            {
                int cant = restante / b2000;
                Console.WriteLine("2000 x " + cant);
                restante = restante - (cant * b2000);
            }

            if (restante >= b1000)
            {
                int cant = restante / b1000;
                Console.WriteLine("1000 x " + cant);
                restante = restante - (cant * b1000);
            }

            if (restante >= b500)
            {
                int cant = restante / b500;
                Console.WriteLine("500 x " + cant);
                restante = restante - (cant * b500);
            }

            if (restante >= b200)
            {
                int cant = restante / b200;
                Console.WriteLine("200 x " + cant);
                restante = restante - (cant * b200);
            }

            if (restante >= b100)
            {
                int cant = restante / b100;
                Console.WriteLine("100 x " + cant);
                restante = restante - (cant * b100);
            }

            if (restante >= b50)
            {
                int cant = restante / b50;
                Console.WriteLine("50 x " + cant);
                restante = restante - (cant * b50);
            }

            if (restante >= b20)
            {
                int cant = restante / b20;
                Console.WriteLine("20 x " + cant);
                restante = restante - (cant * b20);
            }

            if (restante >= b10)
            {
                int cant = restante / b10;
                Console.WriteLine("10 x " + cant);
                restante = restante - (cant * b10);
            }

            double resto = vuelto - (int)vuelto + restante;

            if (resto >0 )
            {
                Console.WriteLine("debido a que no es un numero que sea minimamente multiplo de 10, el dinero restante se toma como propina");
            }
        }
            Console.ReadKey();
        }
    }


