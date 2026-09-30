# Nivel 3 — Firewalls adyacentes (Matriz)

**Contexto:** Tenés que evaluar el riesgo local en el mapa de seguridad.

**Objetivo:** Implementar `CountAdjacent(int[,] grid, int row, int col) -> int` que cuente cuántos **1** hay alrededor de `(row, col)` en **4 direcciones**: arriba, abajo, izquierda y derecha.

## Reglas
- Considerar solo vecinos: `(r-1,c)`, `(r+1,c)`, `(r,c-1)`, `(r,c+1)`.
- **No** salirte de los límites de la matriz (verificá índices).
- No modifiques nada fuera del bloque `// TODO`.

## Casos de prueba usados por `Program.cs`
Para la matriz:
```
0 1 0
1 0 1
0 1 0
```
- `(1,1)` → **4** vecinos con `1`.

- `(0,0)` → **2** vecinos con `1`.

**Desbloqueo esperado:** `✔ UNLOCK → Fragmento: -OK`

## Pistas
- Obtené `rows = grid.GetLength(0)` y `cols = grid.GetLength(1)`.
- Antes de leer `grid[r,c]`, chequeá `0 <= r < rows` y `0 <= c < cols`.

## Errores comunes
- Contar diagonales (no van en este nivel).
- Acceder a índices negativos o fuera de rango.

## Tiempo sugerido
- 10–12 minutos.

¡Rodeá, evalúa y avanzá! 🧱