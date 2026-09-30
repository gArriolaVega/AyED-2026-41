using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultadoSuma = Calculadora(1, 10, 5);
            double resultadoResta = Calculadora(2, 10, 5);
            double resultadoMult = Calculadora(3, 10, 5);
            double resultadoDiv = Calculadora(4, 10, 5);
            Console.WriteLine("Suma: " + resultadoSuma);
            Console.WriteLine("Resta: " + resultadoResta);
            Console.WriteLine("Multiplicacion: " + resultadoMult);
            Console.WriteLine("Division: " + resultadoDiv);
            Console.ReadKey();
        }
        static double Calculadora(int opcion, double a, double b)
        {
            switch (opcion)
            {
                case 1:
                    return Sumar(a, b);
                case 2:
                    return Restar(a, b);
                case 3:
                    return Multiplicar(a, b);
                case 4:
                    return Dividir(a, b);
                default:
                    Console.WriteLine("Opcion no valida");
                    return 0;
                
            }
        }
        static double Sumar(double a, double b)
        {
            return a + b;
        }
        static double Restar(double a, double b)
        {
            return a - b;
        }
        static double Multiplicar(double a, double b)
        {
            return a * b;
        }
        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por 0 tonto");
                return 0;
            }
            return a / b;
        }

    }
}
