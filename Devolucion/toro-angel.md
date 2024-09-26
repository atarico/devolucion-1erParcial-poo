### Ejercicio 2:

#### Puntos Positivos:

    ✅ Encapsulamiento Correcto
    ✅ Uso de Listas
    ✅ Descuento por Cantidad

#### Observaciones y Mejoras:

1. **_Redundancia al Agregar Flores:_**
   Actualmente, el método Main añade la misma flor al menos seis veces en arreglos florales diferentes. Esto es innecesario, ya que puedes crear diferentes flores o un solo arreglo floral con múltiples flores.
   Puedes agregar múltiples flores a un solo arreglo floral y agregar diferentes arreglos al pedido.

```csharp
Flor flor1 = new Flor("Rosa", 5);
Flor flor2 = new Flor("Tulipán", 3);

ArregloFloral arregloFloral1 = new ArregloFloral();
arregloFloral1.AgregarFlores(flor1);
arregloFloral1.AgregarFlores(flor2);

pedido.AgregarArregloFloral(arregloFloral1);
```

2. **_Errores en el Cálculo del Total:_**
   El cálculo del total en el método Total sobrescribe el valor en cada iteración del foreach. Esto no es correcto ya que debería sumar el total de cada arreglo floral.
   Se debe sumar el costo de cada arreglo floral en lugar de sobrescribirlo.

```csharp
foreach (var item in ArregloFlores)
{
    total += item.ObtenerCostoArreglo();
}
```

3. **_Mensajes de Excepción:_**
   En la clase Pedido, el método Total tiene el flujo correcto, pero sería útil agregar manejo de errores o condiciones para valores inesperados. Actualmente, no hay manejo de excepciones ni mensajes claros cuando algo sale mal.

4. **_Método MostrarResumenPedido Incompleto:_**
   El método MostrarResumenPedido no muestra detalles de las flores en el pedido. La lógica para mostrar las flores de cada arreglo floral debería estar implementada para que el cliente pueda ver el resumen completo.
   Implementar la lógica para mostrar las flores dentro de cada arreglo floral.

```csharp
foreach (var arreglo in Pedido.ArregloFlores)
{
    Console.WriteLine("Arreglo floral:");
    foreach (var flor in arreglo.Flores)
    {
        Console.WriteLine($"Flor: {flor.Tipo}, Costo: {flor.Costo:C}");
    }
}
```

### Evaluación General:

El código tiene una estructura sólida y funcional para gestionar pedidos en una florería, pero hay varias mejoras que pueden aplicarse para hacerlo más eficiente y completo. Es necesario mejorar la salida de datos y el manejo de errores.

**¡Buen trabajo!**

#### Puntaje Total: _3 / 3_

---

### Ejercicio 3

### código

#### Puntos Positivos:

    ✅ Encapsulamiento
    ✅ Manejo de Miembros en Clases
    ✅ Relación entre Clases

#### Observaciones y Mejoras:

1. **_Lógica de Disponibilidad de Lugares:_**
   En el código actual, se permite que los miembros se agreguen a una clase incluso si no hay suficientes lugares disponibles. El código arrojará una excepción cuando se intente agregar más miembros de los permitidos, pero esto ocurre después de intentar agregar al miembro, en lugar de evitarlo de antemano.
   Sería mejor prevenir esta operación, mostrando un mensaje antes de intentar agregar al miembro. Puedes capturar la excepción en el método Main y manejarla de forma amigable.

```csharp
try
{
    clase1.AgregarMiembro(miembro3);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message); // "No hay lugares disponibles"
}
```

2. **_Inconsistencias en la Asignación de Clases:_**
   Actualmente, estás intentando asignar múltiples clases a los mismos miembros sin verificar si estos miembros ya están inscritos en otra clase que puede coincidir en el horario o tener restricciones adicionales (por ejemplo, un miembro no puede estar en dos clases al mismo tiempo). Esto podría ser una mejora si el gimnasio tiene un sistema de horarios y restricciones por miembro.
   Podrías agregar una validación en Clase para verificar si el miembro ya está registrado en la misma clase o si hay un posible conflicto de horarios.

```csharp
public void AgregarMiembro(Miembro miembro)
{
    if (Miembros.Contains(miembro))
    {
    throw new ArgumentException("El miembro ya está registrado en esta clase");
    }
}
```

3. **_Manejo de Costo de Clases:_**
   En el código actual, el costo de la clase está almacenado, pero no se utiliza para calcular el total que un miembro debe pagar. Podrías implementar una funcionalidad que calcule el costo total de todas las clases que toma un miembro, o agregar métodos adicionales para generar resúmenes de pago.
   Implementa un método que sume el costo de todas las clases en las que un miembro está inscrito.

```csharp
public double ObtenerCostoTotal()
{
    double total = 0;
    foreach (var clase in Clases)
    {
        total += clase.Costo;
    }
    return total;
}
```

4. **_Descripciones y Nombres más Claros:_**
   Algunos nombres de clases y variables son poco descriptivos. Por ejemplo, "Clase1" y "Clase2" no brindan mucha información sobre el tipo de clase que se está representando.
   Usa nombres más descriptivos como "Yoga", "Pilates", o "Spinning".

5. **_Resumen de Miembros Inscritos en el Gimnasio:_**
   Actualmente no hay una manera de listar las clases y los miembros inscritos en cada clase. Agregar un método para mostrar un resumen de las clases y los miembros podría ser útil.
   Implementa un método en la clase Gym para listar todas las clases y sus miembros.

```csharp
public void MostrarClases()
{
    foreach (var clase in Clases)
    {
        Console.WriteLine($"Clase: {clase.Nombre} - Instructor: {clase.Instructor.Nombre}");
        Console.WriteLine("Miembros:");
        foreach (var miembro in clase.Miembros)
        {
            Console.WriteLine($"- {miembro.Nombre}");
        }
        Console.WriteLine("-----------------------");
    }
}
```

6. **_Mejoras en la Salida de Datos:_**
   El programa actual no genera ninguna salida útil sobre las clases y los miembros. Sería beneficioso implementar una funcionalidad que muestre un resumen de la información.

### Evaluación General:

El código está bien estructurado, con relaciones claras entre instructores, miembros, y clases, pero podría mejorarse con validaciones adicionales y una mejor salida de datos.

#### Puntaje Total: _2 / 4_
