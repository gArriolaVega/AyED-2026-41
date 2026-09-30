using System;
using System.Collections;


public abstract class Personaje
{

    public string Nombre { get; private set; }
    public int Vida { my_protected_set; get; private set; }

    protected Personaje(string nombre, int vidaInicial)
    {
        Nombre = nombre;
        Vida = vidaInicial;
    }


    public abstract void Atacar();


    public void RecibirDano(int cantidad)
    {
        Vida -= cantidad;
        if (Vida < 0) Vida = 0;
        Console.WriteLine($"{Nombre} recibió {cantidad} de daño. Vida restante: {Vida}");
    }
}


public class Mago : Personaje
{
    public int Mana { get; private set; }

    public Mago(string nombre, int vida, int mana) : base(nombre, vida)
    {
        Mana = mana;
    }


    public override void Atacar()
    {
        if (Mana >= 10)
        {
            Mana -= 10;
            Console.WriteLine($"{Nombre} lanza una Bola de Fuego 💥. Maná restante: {Mana}");
        }
        else
        {
            Console.WriteLine($"{Nombre} intentó atacar pero no tiene suficiente maná 💨.");
        }
    }
}


public class Guerrero : Personaje
{
    public int Fuerza { get; private set; }

    public Guerrero(string nombre, int vida, int fuerza) : base(nombre, vida)
    {
        Fuerza = fuerza;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca con un Espadazo ⚔️ causando un impacto de fuerza {Fuerza}.");
    }
}

// 4. PROGRAMA PRINCIPAL (Instanciación y Uso)
class Program
{
    static void Main(string[] args)
    {
        // Instanciación (Creación de Objetos)
        Personaje miMago = new Mago("Gandalft", 80, 20);
        Personaje miGuerrero = new Guerrero("Conan", 120, 15);

        // Uso de Polimorfismo mediante una lista de la clase base
        Personaje[] equipo = { miMago, miGuerrero };

        Console.WriteLine("--- ¡INICIA LA BATALLA! ---\n");

        // Un mismo mensaje ("Atacar()") ejecuta comportamientos distintos según el objeto real
        foreach (Personaje p in equipo)
        {
            p.Atacar();
        }

        Console.WriteLine("\n--- RECIBIENDO DAÑO ---");
        miMago.RecibirDano(25);

        // Intento fallido de atacar por falta de maná en el segundo turno
        miMago.Atacar();
        miMago.Atacar();
    }
}
