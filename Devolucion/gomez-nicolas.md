### Gomez, Devolución:

### Ejercicio 1:

#### Puntos Positivos

- ✅ Sintaxis clara
- ✅ Uso de propiedades privadas
- ✅ Uso de listas
- ✅ Modularidad y encapsulamineto

#### Observaciones y mejoras:

1. **_Redundancia en el constructor vacío:_** En la clase `ArregloFloral` se inicializan 2 veces Flores.

```csharp
public ArregloFloral()
{
    Flores = new List<Flor>();
}
```

No es necesario inicializar Flores dentro del constructor, ya que ya lo has inicializado cuando declaraste el atributo:

```csharp
public List<Flor> Flores { get; private set; } = new List<Flor>();
```

2. **_Corrección en la salida del método MostrarDetalles:_** Falta llamar a `ObtenerCostoArreglo()` en lugar de mostrar el nombre del método:

_mal_

```csharp
Console.WriteLine($"Costo Total: {ObtenerCostoArreglo}");
```

_bien_

```csharp
Console.WriteLine($"Costo Total: {ObtenerCostoArreglo()}");
```

3.  **_En la clase `Program`:_**
    Usa nombres de variables con la primera letra minúscula por ej `arregloFloral`, `pedido` y `cliente` como lo hiciste en `flor1`, etc.

Conclusión:

El código está muy bien estructurado y organizado, con pequeños detalles que pueden mejorarse aún mas

**¡Buen trabajo!**

#### Puntaje total: **3 / 3 pts**

---

### Ejercicio 2:

#### Puntos Positivos

✅ Buena estructura general de las clases
✅ Uso adecuado de propiedades con getters privados
✅ Implementación correcta de relaciones entre clases
✅ Manejo de listas para miembros de la clase

_La separación de responsabilidades entre las clases Instructor, Miembro y Clase está bien pensada y proporciona una estructura clara y modular._

#### Observaciones y mejoras:

1. **_Validación en el constructor de Clase:_**
   Sería bueno añadir validaciones para asegurar que los valores de costo y lugaresDisponibles sean positivos:

```csharp
Clase(string nombre, double costo, int lugaresDisponibles, Instructor instructor)
{
    if (costo < 0 || lugaresDisponibles < 0)
    throw new ArgumentException("El costo y los lugares disponibles deben ser positivos.");

    Nombre = nombre;
    Costo = costo;
    LugaresDisponibles = lugaresDisponibles;
    Instructor = instructor;
}
```

2. **_Método AgregarMiembro con lista:_**
   El método que agrega una lista de miembros reemplaza completamente la lista existente. Probablemente quieras añadir los nuevos miembros a la lista existente:

```csharp
void AgregarMiembro(List<Miembro> miembros)
{
    if (LugaresDisponibles >= miembros.Count)
    {
        Miembros.AddRange(miembros);
        LugaresDisponibles -= miembros.Count;
    }
    else
    {
        Console.WriteLine("No hay suficientes lugares disponibles!");
    }
}
```

3. **_Uso de using innecesarios:_**
   Algunos using statements no se utilizan y pueden ser eliminados, como `System.Linq` y `System.Text` en todas las clases.

4. **_Consideración de uso de decimal:_**
   Para el costo de la clase, considerar el uso de decimal en lugar de double para evitar problemas de precisión en cálculos monetarios.

5. **_Números de miembro repetidos:_**
   Todos los miembros tienen el mismo número (123). Se debería validar que los miembros no pueden tener el mismo número

### Evaluación general:

El código muestra una buena comprensión de los conceptos de orientación a objetos y una estructura bien pensada.

**¡Muy buen trabajo!**

#### Puntaje total: **4 / 4 pts**

---