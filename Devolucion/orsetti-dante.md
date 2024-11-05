### Ejercicio 1:

#### Análisis

- ✅ Relaciones correctas.
- ✅ Clases correctas.

#### Observaciones

1. **_Cuidado con los valores por defecto a la hora de crear el diagrama._**
2. **_Poner nombres en singular, estamos trabajando con entidades no tablas. ._**

#### Puntaje total: _3 / 3_

---

### Ejercicio 2:

#### Puntos Positivos:

    ✅ Encapsulación
    ✅ Uso de Constructores Sobrecargados
    ✅ Cálculo de Total y Descuentos
    ✅ Mostrar Resumen del Pedido
    ✅ Uso de Listas

### Observaciones y Mejoras:

1. **_Nombres de Variables y Métodos:_** Podrías mejorar la legibilidad del código utilizando nombres más descriptivos para algunas propiedades. Por ejemplo, el método ObtenerCostoArreglo podría llamarse simplemente CalcularCosto.

```csharp
public double CalcularCosto()
{
    double costoArreglo = 0;
    foreach (var flor in _flores)
    {
        costoArreglo += flor.Costo;
    }
    return costoArreglo;
}
```

2. **_Métodos de Descuento:_** En la propiedad Total, el cálculo del descuento y el total podría ser más directo al hacer la verificación en un solo paso.

```csharp
public double Total
{
    get
    {
        double total = 0;
        foreach (var arreglo in _arreglosFlorales)
        {
            total += arreglo.CalcularCosto(); // Uso del nuevo método
        }
        return _arreglosFlorales.Count > 5 ? total * 0.9 : total; // Aplicación directa del descuento
    }
}
```

3. **_Manejo de Excepciones:_** No hay manejo de errores para agregar o quitar flores/arreglos. Deberías considerar la posibilidad de que se intente quitar un elemento que no existe en la lista.

```csharp
public void QuitarFlor(Flor flor)
{
    if (!_flores.Contains(flor))
    {
        Console.WriteLine("La flor no está en el arreglo.");
        return;
    }
    _flores.Remove(flor);
}
```

4. **_Validaciones en Constructor:_** En la clase Pedido, podrías validar que el pedido no esté vacío al inicializarlo. Si está vacío, puedes lanzar una excepción o establecer un valor predeterminado.

```csharp
public Pedido(List<ArregloFloral> arreglos)
{
    if (arreglos == null || !arreglos.Any())
        throw new ArgumentException("El pedido debe contener al menos un arreglo floral.");
    _arreglosFlorales = arreglos;
}
```

### Evaluación General:

El código está bien estructurado y proporciona una funcionalidad completa para manejar flores, arreglos florales, pedidos y clientes. Hay áreas en las que puedes mejorar la gestión de errores.

**¡Excelente Trabajo!**

#### Puntaje Total: _3 / 3_

---

### Ejercicio 3:

### Diagrama.

#### Análisis

- ✅ Excelente

### Código

#### Puntos Positivos:

    ✅ Encapsulación Correcta
    ✅ Clases Bien Definidas
    ✅ Métodos de Inscripción
    ✅ Mostrar Detalles de la Clase

1. **_Sugerencias de Mejora:_**
   Validación de Capacidad de la Clase: Actualmente, es posible agregar miembros a la clase incluso si ya no hay lugares disponibles. Deberías agregar una validación para evitar que esto suceda.

```csharp
public void AgregarMiembro(Miembro miembro)
{
    if (_lugaresDisponibles > 0)
    {
        _miembros.Add(miembro);
        _lugaresDisponibles;
    }
    else
    {
        Console.WriteLine("No hay lugares disponibles en esta clase.");
    }
}
```

2. **_Verificación de Instructor Nulo:_** En el método MostrarDetalles, podrías validar si hay un instructor asignado antes de mostrar su información, ya que actualmente puede lanzar una excepción si no se ha asignado instructor.

```csharp
Console.WriteLine($"Instructor: {(Instructor != null
    ? $"{Instructor.Nombre}, Experiencia: {Instructor.Experiencia} años"
    : "No asignado")}"
);
```

3. **_Restricción de Remoción de Miembros:_** Deberías verificar si el miembro que se intenta remover está efectivamente en la lista antes de realizar la operación, para evitar errores.

```csharp
public void QuitarMiembro(Miembro miembro)
{
    if (_miembros.Contains(miembro))
    {
        _miembros.Remove(miembro);
        ++_lugaresDisponibles;
    }
    else
    {
        Console.WriteLine("El miembro no está inscrito en esta clase.");
    }
}
```

4. **_Uso de Métodos Para Mejorar Legibilidad:_** Considera crear métodos auxiliares para tareas repetitivas, como calcular cuántos miembros hay inscritos, para mejorar la legibilidad y el mantenimiento del código.

### Evaluación General:

El código es sólido y cubre las funcionalidades requeridas. Considera también agregar manejo de errores y mensajes más informativos para los usuarios.

**¡Muy Buen Trabajo!**

#### Puntaje final: _4 / 4_

---

## Primer Parcial

<table>
  <tr>
    <th>Ejercicio 1</th>
    <th>Ejercicio 2</th>
    <th>Ejercicio 3</th>
    <th>Total</th>
    <th>Estado</th>
  </tr>
  <tr>
    <td align="center">3</td>
    <td align="center">3</td>
    <td align="center">4</td>
    <td align="center">10</td>
    <td align="center">Aprobado</td>
  </tr>
</table>
