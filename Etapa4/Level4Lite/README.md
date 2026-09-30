# Nivel 4 — Cifrado +1 (Funciones + Chars)

**Contexto:** Último candado: cifrar un mensaje de verificación.

**Objetivo:** Implementar `CaesarPlusOne(string s) -> string` que desplace **cada letra** +1 posición en el alfabeto, manteniendo mayúsculas/minúsculas. Otros caracteres quedan igual.

## Reglas
- `a..z` → siguiente letra (con `z → a`).

- `A..Z` → siguiente letra (con `Z → A`).

- Mantener el **case** de letras.

- No modifiques nada fuera del bloque `// TODO`.

## Caso de prueba usado por `Program.cs`
- Entrada: `"ctOS"`

- Salida esperada: `"duPT"`

**Desbloqueo esperado:** `✔ UNLOCK → Código final: CT-ACCESS-OK`

## Pistas
- Podés sumar 1 a un `char` relativo a una **base**: `'a'` o `'A'`.

- Para wrap-around: si pasa de `'z'`/`'Z'`, volver a `'a'`/`'A'`.

- `char.IsLetter(c)`, `char.IsLower(c)`, `char.IsUpper(c)` pueden ayudar.

## Errores comunes
- No respetar mayúsculas/minúsculas.
- Rotar números o signos (no deben cambiar).

## Tiempo sugerido
- 10–12 minutos.

¡Código verificado. ctOS restaurado! ✅