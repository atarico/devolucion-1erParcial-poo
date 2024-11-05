### Ejercicio 1:

#### Observaciones

1. **_Saber próximo mantenimiento:_**
   La empresa desea saber cuándo se va realizar el siguiente mantenimiento de un vehículo, para ello haría falta un método `CalcularProximoMantenimiento()` por ejemplo.

2. **_Relación entre `Vehiculo` y `Conductor`:_**
   La relación es mucho más candidata a ser una simple Asociación con una cardinalidad 1 a 1, o 0…1 a 0…1; por el hecho de la representación del ‘estado’ dado en un momento concreto, un vehículo va a ser conducido por un solo conductor, sí, ese vehículo a lo largo de su vida útil va a ser conducido por muchos conductores, pero en el momento que tenga que ser conducido solo habrá uno.

3. **_Mantenimiento:_**
   La responsabilidad de registrar el mantenimiento le pertenece al supervisor (entidad faltante); y no debería estar en `Vehículo`

#### Puntaje total: _1.5 / 3_

---

### Ejercicio 2:

#### Puntos Positivos:

    ✅ Uso de clases bien separadas
    ✅ Encapsulamiento
    ✅ Métodos claros

#### Observaciones y Mejoras:

1. **_Corrección en el cálculo del descuento en ObtenerCostoArreglo:_**
   Actualmente, el método está bien implementado, pero se encuentra un pequeño error en la línea costo =+ flor.Costo; que debería ser costo += flor.Costo;. Esto asegura que el costo de cada flor se sume correctamente en lugar de sobrescribir el valor acumulado.

```csharp

public double ObtenerCostoArreglo()
{
    double costo = 0;
    foreach (var flor in Flores)
    {
    costo += flor.Costo; // Corregido de =+ a +=
    }

    if (Flores.Count > 5)
    {
        costo -= costo * 0.10;  // Aplica un descuento del 10% si hay más de 5 flores
    }
    return costo;
}
```

2. **_Error en la propiedad Total de la clase Pedido:_** La propiedad Total no está calculando el costo correctamente, ya que se está utilizando la variable Total dentro de sí misma, lo que causa un bucle infinito. El cálculo debe ser hecho directamente llamando a CantidadPedido(), que suma los costos de los arreglos.

```csharp

public double ObtenerTotal()
{
    double total = CantidadPedido(); // Sumar el costo total de los arreglos
    if (DescuentoAplicado())
    {
        total \*= 0.90; // Aplica un 10% de descuento si es aplicable
    }
    return total;
}
```

3. **_Corregir el método DescuentoAplicado:_** El método DescuentoAplicado está evaluando incorrectamente la cantidad de flores. En lugar de contar solo los arreglos, deberías contar todas las flores dentro de los arreglos para aplicar el descuento de manera correcta.

```csharp

public bool DescuentoAplicado()
{
    int totalFlores = 0;
    foreach (var arreglo in ArreglosFlorales)
    {
        totalFlores += arreglo.Flores.Count; // Contar todas las flores
    }

    return totalFlores >= 6;  // Aplicar descuento si hay 6 o más flores

}
```

4.**_Constructor de Cliente:_** El constructor de Cliente está bien implementado, pero podría ser más robusto si validaras que el pedido no sea null al momento de asignarlo. Esto podría prevenir errores al intentar crear un cliente sin un pedido válido.

```csharp

public Cliente(string nombre, Pedido pedido)
{
    if (pedido == null)
    {
        throw new ArgumentNullException(nameof(pedido), "El pedido no puede ser nulo.");
    }
    Nombre = nombre;
    Pedido = pedido;
}
```

5. **_Mejorar el método MostrarResumenPedido:_** El método está bien estructurado, pero podrías incluir información más detallada sobre cada arreglo floral, como el costo de cada arreglo, y luego el costo total con o sin descuento. Esto mejoraría la claridad del resumen para el cliente.

6. **_Error en el Main:_** El Main funciona en términos generales, pero debes asegurarte de que el método MostrarResumenPedido muestre toda la información necesaria. Además, en el segundo arreglo floral (arreglo2), falta agregarlo al pedido para que el cálculo del total del pedido sea correcto.

```csharp

static void Main()
{
    // Crear flores
    Flor flor1 = new Flor("Rosa", 10);
    Flor flor2 = new Flor("Jasmín", 2);
    Flor flor3 = new Flor("Violetas", 6);
    Flor flor4 = new Flor("Tulipán", 8);
    Flor flor5 = new Flor("Girasol", 7);
    Flor flor6 = new Flor("Orquídea", 12);
    // Crear un arreglo floral y agregar flores
    ArregloFloral arreglo1 = new ArregloFloral();
    arreglo1.AgregarFlor(flor1);
    arreglo1.AgregarFlor(flor2);
    arreglo1.AgregarFlor(flor3);
    ArregloFloral arreglo2 = new ArregloFloral();
    arreglo2.AgregarFlor(flor4);
    arreglo2.AgregarFlor(flor5);
    arreglo2.AgregarFlor(flor6);
    // Crear pedido y agregar arreglos florales
    Pedido pedido1 = new Pedido();
    pedido1.AgregarArreglo(arreglo1);
    pedido1.AgregarArreglo(arreglo2);  // Agregar segundo arreglo
    // Crear cliente
    Cliente cliente1 = new Cliente("Paola", pedido1);
    // Mostrar resumen del pedido
    cliente1.MostrarResumenPedido();
}
```

Evaluación general:

Tu código tiene una estructura clara y modular, con un buen uso de clases, encapsulamiento y listas. Sin embargo, algunos errores en la lógica del descuento y el cálculo del total hacen que no funcione del todo bien.

**¡Buen Trabajo!**

#### Puntaje Total: _2 / 3_

---

### Ejercicio 3:

### Diagrama.

#### Análisis:

- ✅ Clases correctas.

#### Observaciones

1. **_Método en `Miembro`:_**
   El método publico `MostrarDetallesMiembro()` no debería recibir el parámetro `clase`.

2. **_Cardinalidad entre `Instructor` y `Clase`_**
   Lo mismo con el ejercicio 1, es una representación de estado; no va a haber más de un `Instructor` dando la clase al mismo tiempo.

**¡Repasar 'estado' de un objeto!**

#### Puntos Positivos:

    ✅ Estructura clara y bien definida
    ✅ Uso correcto de listas y clases
    ✅ Lógica básica funcional

#### Observaciones y Mejoras:

1. **_Problema con el cálculo del cupo restante:_** En el método ActualizarCupo, estás disminuyendo el cupo recibido como parámetro, pero no estás actualizando el valor de Cupo de la clase Clase. Deberías restar el cupo directamente del atributo Cupo y no del parámetro local. Aquí la corrección:

```csharp
public int ActualizarCupo(int cantidad)
{
    if (Cupo <= 0)
    {
        Console.WriteLine($"No hay disponibilidad en esta clase :( ");
    }
    else
    {
        Cupo -= cantidad;  // Actualizar el atributo de la clase, no el parámetro
        Console.WriteLine($"Cupo actualizado!! Lugares restantes en {Nombre}: {Cupo}");
    }
    return Cupo;
}
```

2. **_Nombres de métodos más claros:_** El nombre del método AgregarClaseMiembro puede ser un poco confuso, ya que podría dar la impresión de que se está añadiendo un miembro a la clase en lugar de lo contrario. Sería más claro si lo nombras InscribirseEnClase o algo parecido, lo cual también sigue la convención de usar verbos para las acciones.

3. **_Validación adicional en el constructor de Clase:_** Sería recomendable agregar una validación en el constructor de la clase Clase para asegurarse de que los cupos y el costo sean valores válidos. Por ejemplo, puedes evitar crear una clase con cupos negativos o costo menor a cero:

```csharp
    public Clase(string nombre, int cupo, Instructor instructor, double costo)
    {
        if (cupo < 0) throw new ArgumentException("El cupo no puede ser negativo.");
        if (costo < 0) throw new ArgumentException("El costo no puede ser negativo.");

        Nombre = nombre;
        Cupo = cupo;
        Instructor = instructor;
        Costo = costo;
    }
```

### Evaluación General:

El código tiene una buena estructura y está muy bien organizado. Es claro y fácil de seguir. Tiene detalles a mejorar como todo programa pero en general es una muy buena resolución

**¡Muy buen trabajo!**

#### Puntaje Total: _3.5 / 4_

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
    <td align="center">1.5</td>
    <td align="center">2</td>
    <td align="center">3.5</td>
    <td align="center">7</td>
    <td align="center">Aprobado</td>
  </tr>
</table>
