using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ingrese la cantidad de componentes: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] vector1 = new double[n];
        double[] vector2 = new double[n];

        Console.WriteLine("ingrese los valores del primer vector:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("elemento " + (i + 1) + ": ");
            vector1[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("ingrese los valores del segundo vector:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("elemento " + (i + 1) + ": ");
            vector2[i] = Convert.ToDouble(Console.ReadLine());
        }

        double productoEscalar = 0;

        for (int i = 0; i < n; i++)
        {
            productoEscalar += vector1[i] * vector2[i];
        }

        Console.WriteLine("producto escalar: " + productoEscalar);

        Console.ReadKey();
    }
} 