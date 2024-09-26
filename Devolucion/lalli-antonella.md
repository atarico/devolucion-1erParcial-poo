### Lalli Antonella, Devolución:

#### Ejercicio 1:

#### Análisis

- ✅ Relaciones y cardinalidad correcta

#### Observaciones

1. **_Falta una entidad:_**
   Falta la principal función del sistema que es hacer mantenimientos a los vehículos y calcular el próximo mantenimiento, para ello era necesario involucrar a otra entidad.

### Evaluación general:

En este ejercicio solo se debía diagramar, no era necesario escribir su respectivo código.

**¡Leer bien el enunciado!**

#### Puntaje total: _2 / 3_

### Ejercicio 2:

#### Puntos Positivos

- ✅ Buena estructura de clases con separación de responsabilidades
- ✅ Uso de encapsulamiento con propiedades privadas
- ✅ Implementación de constructores para inicializar objetos
- ✅ Uso de listas para manejar colecciones de flores y arreglos florales

#### Observaciones y mejoras:

1. **_Uso de decimal para valores monetarios:_**
   Es recomendable usar decimal en lugar de double para valores monetarios para evitar errores de redondeo:

```csharp
public decimal Costo { get; private set; }
public Flor(string tipo, decimal costo)
```

2. **_Cálculo de descuento en la clase Pedido:_**
   El cálculo del descuento tiene un error. Debería ser:

```csharp
costo -= (0.1m \* costo); // 10% de descuento
```

3. **_Implementación incompleta de MostrarResumenPedido:_**
   El método MostrarResumenPedido en la clase Cliente no muestra realmente los detalles del pedido:

```csharp
public void MostrarResumenPedido()
{
Console.WriteLine($"El cliente {Nombre} realizó el siguiente pedido:");
    Console.WriteLine($"Total del pedido: ${Pedido.ObtenerTotal():F2}");
// Aquí podrías añadir más detalles sobre los arreglos florales
}
```

4. **_Creación limitada de objetos:_**
   Se crean varias flores, pero solo se usa un arreglo floral con dos flores. Sería mejor demostrar más variedad.

5. **_Demostración incompleta de funcionalidades:_**
   No se demuestra la funcionalidad de descuento (se necesitarían más de 5 arreglos).

### Evaluación general:

La estructura general está bien, pero hay algunas cosas que podrían mejorarse, especialmente en cuanto a la precisión de los cálculos y la implementación.

**¡Buen trabajo en general!**

#### Puntaje total: _2 / 3_

---

### Ejercicio 3:

**Ejercicio NO resuelto**

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
    <td align="center">2</td>
    <td align="center">2</td>
    <td align="center">0</td>
    <td align="center">4</td>
    <td align="center">Desaprobado</td>
  </tr>
</table>
