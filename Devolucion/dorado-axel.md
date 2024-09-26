### Ejercicio 2:

#### Puntos Positivos:

    ✅ Encapsulamiento adecuado
    ✅ Buen uso de listas

### Observaciones y mejoras:

1. **_Error en el cálculo del descuento en `ObtenerCostoArreglo()`:_**
   El bloque if que verifica si hay más de 5 flores para aplicar un descuento está colocado después del return, lo que hace que nunca se ejecute. La estructura correcta sería mover el if antes del return.

```csharp

public double ObtenerCostoArreglo()
{
    double acum = 0;
    foreach (var flor in flores)
    {
        acum += flor.Costo;
    }

    if (flores.Count > 5)
    {
        acum -= acum * 0.10;  // Aplica un descuento del 10%
    }
    return acum;

}
```

2. **_Error en `CantidadPedido()` en la clase Pedido:_**
   El método `CantidadPedido` actualmente está sumando el número de arreglos florales, pero lo hace incorrectamente al agregar el número de elementos en cada iteración. En su lugar, debería sumar el costo total de los arreglos.

```csharp

public double CantidadPedido()
{
    double acum1 = 0;
    foreach (var arreglo in arreglosFlorales)
    {
        acum1 += arreglo.ObtenerCostoArreglo(); // Suma el costo de cada arreglo floral
    }
    return acum1;
}
```

3. **_Inconsistencia en la clase Cliente:_**
   En el constructor de Cliente, se pasa un Pedido como parámetro, pero dentro del constructor se asigna un nuevo objeto Pedido en lugar de utilizar el que se pasa como argumento. Hay corregir esto para que se asigne el pedido que se pasa al constructor.

```csharp

public Cliente(string nombre, Pedido pedido)
{
    this.Nombre = nombre;
    this.pedido = pedido; // Asigna el pedido que se pasa al constructor
}
```

4. **_El método` MostrarDetallesPedido` está vacío:_**
   El método `MostrarDetallesPedido` debería mostrar información sobre el pedido del cliente. Podrías mejorar este método para que imprima el nombre del cliente, el total del pedido y si se aplicó algún descuento en base al número de arreglos florales.

```csharp

public void MostrarDetallesPedido()
{
Console.WriteLine($"Cliente: {Nombre}");
    Console.WriteLine($"Total del Pedido: ${pedido.CantidadPedido()}");
}
```

5. **_El `Main()` está incompleto:_**

   El Main comienza la creación de objetos Flor, pero no se realiza ninguna otra acción para mostrar cómo se comporta el sistema. Debes crear un Pedido, agregar arreglos florales, y luego asignarlo a un cliente para mostrar el comportamiento completo del sistema.

6. **_Agregar funcionalidad de agregar arreglos al pedido:_**
   El código no contiene un método para agregar arreglos florales al pedido. Puedes implementar un método en la clase Pedido para manejar esto.

```csharp
public void AgregarArreglo(ArregloFloral arreglo)
{
    arreglosFlorales.Add(arreglo);
}
```

### Evaluación general:

El código tiene una estructura clara y modular, pero hay varios errores lógicos que impiden su correcto funcionamiento. Con algunos ajustes en la lógica de los métodos y el flujo del programa en el Main, se puede mejorar considerablemente.

#### Puntaje total: _1 / 3_

_Recomendación: Implementa las correcciones y completa el Main para verificar el comportamiento del programa._

### Ejercicio 3:

**No resuelto**

#### Puntaje total: _0 / 4_

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
    <td align="center"></td>
    <td align="center">1</td>
    <td align="center">0</td>
    <td align="center"></td>
    <td align="center">Desaprobado</td>
  </tr>
</table>
