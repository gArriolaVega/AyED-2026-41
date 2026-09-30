using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 2 – Ping Check (LITE)");
        int[] p = { 13, 250, -5, 40, 40, 40, 100, 205, 100 }; // válidos: 13, 40, 100 en idx 0,3,6
        int s = Level2.SumValidEveryThird(p);
        bool ok = s == (13 + 40 + 100); // 153
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -ACCESS" : "🔒 LOCKED");
    }
}

static class Level2
{
    // Sumar p[i] para i % 3 == 0, solo si 0 <= p[i] <= 200
    public static int SumValidEveryThird(int[] p)
    {
        // TODO: implementar
        return 0; // <- reemplazar por tu solución
    }
}