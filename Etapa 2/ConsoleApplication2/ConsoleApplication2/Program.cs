using System;

class Program
{
    static void Main()
    {
        string nombre;
        string segundoNombre;
        string apellido;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su segundo nombre: ");
        segundoNombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        apellido = Console.ReadLine();

        Console.WriteLine("Iniciales: " + nombre[0] + segundoNombre[0] + apellido[0]);
        Console.ReadKey();
    }
}
 