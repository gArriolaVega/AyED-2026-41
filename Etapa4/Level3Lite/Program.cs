using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        // TODO: implementar
        // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
        // Devolver cuántos valen 1
        return 0; // <- reemplazar por tu solución
    }
}