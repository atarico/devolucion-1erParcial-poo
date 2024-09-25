### Ejercicio 2:

#### Puntos Positivos:

    ✅ Sintaxis clara y concisa
    ✅ Encapsulamiento
    ✅ Uso de clases adecuadas
    ✅ Modularidad

### Observaciones y mejoras:

1.  **_Falta de tipos genéricos en las listas:_**
    Las listas Flores y ArreglosFlorales no tienen un tipo definido en las declaraciones. Se debe usar el tipo genérico List<Flor> y List<ArregloFloral> para evitar ambigüedades y posibles errores.

```csharp
public List<Flor> Flores { get; private set; } = new List<Flor>();
public List<ArregloFloral> ArreglosFlorales { get; private set; } = new List<ArregloFloral>();
```

2. **_Constructor vacío en ArregloFloral innecesario:_**
   Dado que ya estás inicializando la lista de Flores al momento de declarar la propiedad, el constructor vacío no es necesario. Puedes eliminarlo sin afectar el funcionamiento del código.

3. **_Corrección en la lógica de descuento:_**
   En `MostrarResumenPedido`, el descuento se calcula, pero el mensaje que muestra el descuento es incorrecto. El mensaje debería indicar el monto final con el descuento aplicado, no el valor del descuento en sí. El código correcto sería:

```csharp
if (Pedido.DescuentoAplicado)
{
    Console.WriteLine($"Con un descuento aplicado, el total es: ${Pedido.Total \* 0.9}");
}
```

4. **_Repetición de inicialización de lista:_**
   No es necesario inicializar ArreglosFlorales dos veces en la clase Pedido, ya que se está haciendo en el cuerpo de la clase y también en el constructor.

5. **_Mensajes de terminal: _**
   Es necesario que al cliente se le muestren los detalles de las flores, los arreglos y el valor de todo

### Evaluación general:

Con algunos ajustes menores como la tipificación de listas, la eliminación de constructores vacíos, y la mejora en la lógica de descuento mejorarán la calidad general del código.

**¡Muy buen trabajo!**

#### Puntaje total: **2 / 3 pts**

---

### Ejercicio 3:

### código:

#### Puntos Positivos:

    ✅ Buena estructuración del código
    ✅ Encapsulamiento correcto
    ✅ Uso de listas
    ✅ Modularidad

### Observaciones y mejoras:

1. **_Validación en la inscripción de clases:_**
   No hay validación para verificar si aún hay lugares disponibles antes de inscribir a un cliente en la clase. Esto podría causar que el número de lugares sea negativo, lo cual no es correcto. Agregar una validación evitaría esto.

```csharp
public void InscripcionClase(Clase clase)
{
    if (clase.Lugares > 0)
    {
        Clases.Add(clase);
        clase.Lugares--;
        Console.WriteLine($"{Nombre} te anotaste en la clase: {clase.NombreClase} y quedan {clase.Lugares} lugares");
    }
    else
    {
        Console.WriteLine($"Lo siento, no hay lugares disponibles para la clase: {clase.NombreClase}");
    }
}
```

2. **_Validación en la clase Clase:_**
   Podrías agregar validaciones en el constructor de la clase Clase para asegurarte de que los valores de Lugares y Costo no sean negativos, lo que sería un caso de entrada inválida.

```csharp
public Clase(Instructor instructor, string nombreClase, int lugares, double costo)
{
    if (lugares < 0 || costo < 0)
    {
        throw new ArgumentException("Lugares y costo deben ser valores positivos.");
    }
    InstructorGym = instructor;
    NombreClase = nombreClase;
    Lugares = lugares;
    Costo = costo;
}
```

3. **_Mejoras en el Main:_**
   Podrías agregar más ejemplos o iteraciones en el `Main` para mostrar otras funcionalidades o comportamientos del sistema, como verificar qué clases imparte un instructor.

### Evaluación general:

Los métodos están bien definidos y la lógica es clara, pero sería útil añadir validaciones y pequeñas mejoras para evitar errores lógicos y permitir un código más robusto.

**¡Buen trabajo!**

#### Puntaje total: **2.5 / 4 pts**
