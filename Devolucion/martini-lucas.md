### Ejercicio 1:

#### Análisis

- ✅ Relaciones correctas.
- ✅ Clases correctas.

#### Observaciones

1. **_Propiedades:_**
   No es necesario poner las propiedades de la superclase en las subclases, me refiero a las propiedades de `Vehículo` en `Colectivo` y `Camion`.

2. **_Estado:_**
   Falta la asignación de ‘estado’ entre `Conductor` y `Vehículo`, es decir una propiedad conductor en `Vehículo` o una propiedad vehículo en `Conductor` para que la relación tenga sentido.

#### Puntaje total: _3 / 3_

---

### Ejercicio 2:

#### Puntos Positivos:

    ✅ Buena estructura de clases
    ✅ Uso de propiedades privadas
    ✅ Método ObtenerCostoArreglo
    ✅ Aplicación de descuentos
    ✅ Flexibilidad en el constructor de ArregloFloral

#### Observaciones y Mejoras:

1. **_Método MostrarResumenPedido:_**
   Posible error en el cálculo del descuento: El resumen siempre muestra tanto el total sin descuento como el total con descuento, incluso si el cliente no cumple con los requisitos del descuento. Sería mejor mostrar solo el precio final dependiendo de si se aplica el descuento o no.

```csharp
public void MostrarResumenPedido()
{
    Console.WriteLine($"Cliente: {Nombre} | Total sin descuento: {Pedido.Total}");
    if (Pedido.DescuentoAplicado)
    {
        Console.WriteLine($"Total con descuento: {Pedido.Total \* 0.9}");
        Console.WriteLine("Descuento Aplicado");
    }
    else
    {
        Console.WriteLine("No cumple requisitos para descuento.");
    }
}
```

2. **_Reutilización de arreglos florales:_**
   Se observa que en el Main se elimina un elemento de la lista de flores (Jazmín o Camelia) y luego se crean nuevos arreglos basados en la misma lista modificada. Esto puede causar confusión o errores al manipular los arreglos.
   Podrías Crear copias separadas de las listas de flores para cada ArregloFloral, evitando la manipulación de la misma lista original.

```csharp
List<Flor> Arreglo2 = new List<Flor>(Arreglo); // Crear copia
ArregloFloral ArregloFloral2 = new ArregloFloral(Arreglo2);
```

3. **_Validaciones adicionales:_**
   Sería bueno validar si se intenta agregar arreglos florales vacíos o flores inexistentes para evitar errores.

```csharp
public void AgregarFlor(Flor flor)
{
    if (flor != null)
    {
        Flores.Add(flor);
    }
    else
    {
        Console.WriteLine("No se puede agregar una flor nula.");
    }
}
```

4. **_Comentarios y documentación:_**
   El código carece de comentarios que expliquen el propósito de cada clase y método. Agregar documentación ayudaría a la legibilidad y mantenimiento del código.
   <u>_Mejora sugerida:_</u> Agregar comentarios para describir las clases y métodos.

5. **_Optimización en el cálculo del total con descuento:_**
   En la propiedad Total, el total se calcula cada vez que se accede a ella. Si el valor es accedido varias veces, podría ser eficiente calcularlo solo una vez y almacenarlo si no ha cambiado el pedido.

### Evaluación General:

El código está bien diseñado y funciona, manejar flores, arreglos florales, pedidos y clientes, con una implementación sencilla y efectiva del cálculo de costos y descuentos. Hay áreas donde se podría optimizar y hacer el código más seguro y robusto, como en la validación de datos y la reutilización de listas.

**¡Excelente Trabajo!**

#### Puntaje Total: _3 / 3_

---

### Ejercicio 3:

### Diagrama.

#### Observaciones

1. **_No se solicita ningún informe o detalles:_**
   El enunciado no se habla nada de obtener detalles de alguna de las entidades, así que los métodos `MostrarDetalles()` y la intrefaz `IMostrable` están demás.

### Código.

#### Puntos Positivos:

    ✅ Uso de Interfaces
    ✅ Encapsulación
    ✅ Control de número de miembros
    ✅ Claridad en la estructura
    ✅ Separación de responsabilidades

#### Observaciones y Mejoras:

1. **_Nombre de la interfaz:_** La interfaz Imostrable podría renombrarse a IMostrable para seguir la convención de nombres de interfaces en C#, que generalmente comienza con "I".

2. **_Propiedad LugaresDisponibles:_** La lógica para calcular LugaresDisponibles restando 1 por cada miembro podría ser simplificada al usar la propiedad Count de la lista.

```csharp
public int LugaresDisponibles
{
    get { return 30 - Miembros.Count; }
}
```

3. **_Número de miembros_**: En la clase Miembro, el campo num estático se incrementa cada vez que se accede a NumeroMiembro, lo que podría dar lugar a un comportamiento no deseado si se accede a esta propiedad múltiples veces. Sería más seguro asignar un número único en el constructor.

```csharp
public Miembro(string nombre)
{
    Nombre = nombre;
    num++; // Incrementar el número en la creación
    NumeroMiembro = num; // Asignar el número al miembro
}
```

4. **_Falta de manejo de excepciones:_** Al agregar miembros a una clase, no hay validaciones que impidan que se agreguen más miembros de los disponibles. Deberías manejar esto para evitar sobrepasar el límite.

```csharp
public void AgregarMiembro(Miembro miembro)
{
    if (LugaresDisponibles > 0)
    {
        Miembros.Add(miembro);
    }
    else
    {
        Console.WriteLine("No hay lugares disponibles en esta clase.");
    }
}
```

### Evaluación General:

El código está bien estructurado y cumple con lo pedido. La implementación de Interfaces es buena, y se vio una buen manejo del los pilares fundamentales de la POO. Tiene algunas cosas menores que mejorar como todos los programas que se desarrollan.

#### Puntaje Total: _4 / 4_

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
