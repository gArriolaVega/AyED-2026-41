using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
        bool ok = Level1.ValidateAccessKey("WD-700000")
                  && !Level1.ValidateAccessKey("WD-123123")
                  && !Level1.ValidateAccessKey("WX-000007")
                  && !Level1.ValidateAccessKey("WD-00007");
        if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
        else Console.WriteLine("🔒 LOCKED");
    }
}

static class Level1
{
    // Debe devolver true solo si:
    // - Empieza por "WD-"
    // - Luego hay exactamente 6 dígitos
    // - La suma de esos 6 dígitos es múltiplo de 7
    public static bool ValidateAccessKey(string key)
    {
        // TODO: implementar
        if (string.IsNullOrEmpty(key) || key.Length != 9 || !key.StartsWith("WD-"))
        {
            return false;
        }

        int suma = 0;

        for (int i = 3; i < key.Length; i++)
        {
            if (!char.IsDigit(key[i]))
            {
                return false;
            }

            
            suma += key[i] - '0';
        }

        return suma % 7 == 0;
    }
}
    
