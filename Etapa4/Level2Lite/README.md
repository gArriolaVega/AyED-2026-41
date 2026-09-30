# Nivel 2 — Ping Check (Vectores)

**Contexto:** El ctOS valida integridad con pings periódicos.

**Objetivo:** Implementar `SumValidEveryThird(int[] p) -> int` para **sumar** únicamente los elementos **válidos** (en `0..200`) en **posiciones múltiplas de 3** (índices 0,3,6,...).

## Reglas
- Recorre el vector y **sumá** `p[i]` solo si `i % 3 == 0`.
- Considerá **válidos** solo valores `0 <= p[i] <= 200`.
- Ignorá el resto (no los sumes).
- No modifiques nada fuera del bloque `// TODO`.

## Caso de prueba usado por `Program.cs`
`int[] p = { 13, 250, -5, 40, 40, 40, 100, 205, 100 };`
- Índices 0,3,6 → valores 13, 40, 100 (los otros son ignorados por rango o índice)
- **Resultado esperado:** `153`

**Desbloqueo esperado:** `✔ UNLOCK → Fragmento: -ACCESS`

## Pistas
- Cuidado con **índice** vs **valor**: la condición es sobre `i`, no sobre `p[i]`.
- Para rango: `if (0 <= p[i] && p[i] <= 200)`.

## Errores comunes
- Sumar posiciones 1,2,4,5… por error.
- Incluir valores fuera de rango.

## Tiempo sugerido
- 10–12 minutos.

¡Los paquetes llegaron íntegros! 📡