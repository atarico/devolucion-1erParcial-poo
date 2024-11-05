### Ejercicio 1:

#### Análisis

- ✅ Clases correctas.

#### Observaciones

1. **_Saber próximo mantenimiento y registrar mantenimiento:_**
   La empresa quiere registrar mantenimientos de los vehículos y desea saber cuándo se va realizar el siguiente mantenimiento de un vehículo, para ello haría falta los métodos `CalcularProximoMantenimiento()` y `RegistrarMantenimiento()` por ejemplo. Esto es responsabilidad del supervisor.

2. **_Estado:_**
   Falta la asignación de ‘estado’ entre `Conductor` y `Vehículo`, es decir una propiedad conductor en `Vehículo` o una propiedad vehículo en `Conductor` para que la relación tenga sentido. Y esto es una relación de Asociación, ya que es mucho más fuerte que el uso del vehículo.

#### Puntaje total: _2 / 3_

---

### Ejercicio 2:

#### Puntos Positivos:

    ✅ Estructura Clara de Clases
    ✅ Uso de Propiedades Calculadas
    ✅ Manejo de Listas
    ✅ Descuentos

#### Observaciones y Mejoras:

1. **_Manejo de Errores en Clases:_**
   En el constructor de Pedido, si se pasa un arregloFloral nulo o vacío, el sistema no manejará adecuadamente este caso y no se generará el pedido correctamente. Sería útil agregar una verificación.

```csharp
public Pedido(ArregloFloral arregloFloral)
{
    if (arregloFloral == null)
    {
        throw new ArgumentException("El arreglo floral no puede ser nulo.");
    }
    ArreglosFlorales.Add(arregloFloral);
}
```

2. **_Constructor de Pedido:_**
   El segundo constructor de Pedido no está asignando los arreglos florales correctamente. Debería ser el otro argumento el que se agrega a ArreglosFlorales.

```csharp
public Pedido(List<ArregloFloral> arreglosFlorales)
{
    arreglosFlorales.AddRange(ArreglosFlorales); // debería ser con la "a" en minúscula
}
```

```csharp

public Pedido(List<ArregloFloral> arreglosFlorales)
{
    ArreglosFlorales.AddRange(arreglosFlorales);
}
```

3. **_Validación de Pedido en Cliente:_**
   En la clase Cliente, si se crea un cliente sin un pedido, el método MostrarResumenPedido lanzará una excepción. Sería útil hacer que el pedido sea opcional y manejar el caso en el que sea nulo.

```csharp
public void MostrarResumenPedido()
{
    if (Pedido == null)
    {
        Console.WriteLine("No hay pedido asociado al cliente.");
        return;
    }
}
```

4. **_Descuentos Aplicados:_**
   La propiedad DescuentoAplicdo debería calcular el monto total después de aplicar el descuento en lugar de solo verificar la cantidad de arreglos. Esto puede ser confuso.
   Implementar un método para calcular el total con descuento.

```csharp
public double ObtenerTotalConDescuento()
{
    double total = Total;
    if (ArreglosFlorales.Count > 5)
    {
        total \*= 0.90; // Aplicar 10% de descuento
    }
    return total;
}
```

5. **_Salida de Datos:_**
   En el método MostrarResumenPedido, la salida sobre el descuento aplicado no es clara. Además, se podría mejorar la presentación de la información.

6. **_Agregar Ejemplos de Uso:_**
   Sería útil incluir más ejemplos de uso en el método Main, mostrando cómo agregar arreglos y calcular el total en diferentes situaciones.

### Evaluación General:

El código está bien diseñado y organizado, pero hay áreas que requieren mejoras en cuanto al manejo de errores y la claridad de la salida. Además, la validación de entradas en los constructores puede evitar problemas en tiempo de ejecución.

#### Puntaje Total: _3 / 3_

---

### Ejercicio 3

### Diagrama.

#### Observaciones

Hay un método privado en `Clase` que no le veo mucho sentido ponerlo privado, aunque sea que otro método de la misma clase lo pueda llegar a utilizar.

#### Código:

#### Puntos Positivos:

    ✅ Uso de Contador Estático para Números de Miembro
    ✅ Estructura Clara y Módulos Separados
    ✅ Métodos para Modificar el Estado

#### Observaciones y Mejoras:

1.  **_Manejo de Espacios Disponibles:_**
    El método AgregarMiembro no verifica si hay espacio disponible antes de agregar un miembro. Esto podría llevar a que se agreguen más miembros de los permitidos y cause un comportamiento no deseado.

```csharp
public void AgregarMiembro(Miembro miembro)
{
    if (EspacioDisponible > 0)
    {
        Miembros.Add(miembro);
        EspacioDisponible--;
    }
    else
    {
        throw new InvalidOperationException("No hay espacio disponible para agregar más miembros.");
    }
}
```

2. **_Verificación al Quitar Miembro:_**
   El método QuitarMiembro no comprueba si el miembro está presente en la lista antes de intentar eliminarlo. Esto podría resultar en una excepción.

```csharp
public void QuitarMiembro(Miembro miembro)
{
    if (Miembros.Contains(miembro))
    {
        Miembros.Remove(miembro);
        EspacioDisponible++;
    }
    else
    {
        throw new InvalidOperationException("El miembro no está en la lista.");
    }
}
```

3. **_Error en MostrarDetalles:_**
   En el método MostrarDetalles, deberías acceder a la propiedad Nombre del instructor, en lugar de imprimir la instancia de Instructor.

```csharp
public void MostrarDetalles()
{
    Console.WriteLine($"Instructor: {Instructor.Nombre}, costo: {Costo}");
    Console.WriteLine($"TotalMiembros: {Miembros.Count}, espacios disponibles: {EspacioDisponible}");
}
```

4. **_Falta de Ejemplos de Uso en Main:_**
   Agregar más ejemplos de cómo interactuar con las clases, como agregar múltiples miembros y quitar algunos, ayudaría a visualizar mejor el funcionamiento.

### Evaluación General:

El código es bastante sólido, pero se pueden implementar mejoras en el manejo de miembros, así como en la presentación de información, el manejo de errores y la mejora de la salida de datos.

#### Puntaje Total: _3 / 4_

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
    <td align="center">2</td>
    <td align="center">3</td>
    <td align="center">3</td>
    <td align="center">8</td>
    <td align="center">Aprobado</td>
  </tr>
</table>
