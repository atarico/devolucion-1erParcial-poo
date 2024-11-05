### Ejercicio 1:

#### Análisis

- ✅ Clases correctas.

#### Observaciones

1. **_Clase `Vehiculo`:_**
   Las propiedades `Camion` y `Autobus` no son correctas dentro de esta clase.

2. **_Estado:_**
   Falta la asignación de ‘estado’ entre `Conductor` y `Vehículo`, es decir una propiedad conductor en `Vehículo` o una propiedad vehículo en `Conductor` para que la relación tenga sentido.
   Falta la cardinalidad y no es una relación de Agregación ya que no es un “todo/parte”.

3. **_Métodos:_**
   ¿Cómo sé que vehículo asignar al conductor y a que vehículo le hago el mantenimiento?
   Falta algún parámetro en los métodos `RegistrarMantenimiento()` y ` AsignarVehiculo()`.

4. **_Saber próximo mantenimiento:_**
   La empresa desea saber cuándo se va realizar el siguiente mantenimiento de un vehículo, para ello haría falta un método `CalcularProximoMantenimiento()` por ejemplo.

#### Puntaje total: _2 / 3_

---

### Ejercicio 2:

#### Puntos Positivos:

    ✅ Organización del Código
    ✅ Uso de Propiedades
    ✅ Uso de Colecciones
    ✅ Constructor Personalizado

#### Observaciones y Mejoras:

1. **_Redundancia al Agregar Flores:_**
   El método AgregarFlor agrega la misma flor cinco veces. Debe agregar la flor solo una vez.
   Corregir para que agregue la flor solo una vez.

```csharp
public void AgregarFlor(Flor flor)
{
    _flores.Add(flor); // Se elimina la repetición
}
```

2. **_Errores en el Cálculo del Total:_**
   En las propiedades Total y DescuentoAplicado, el cálculo sobrescribe el valor total en cada iteración. Se debe sumar los valores en lugar de sobrescribirlos.
   Se deben sumar los costos en lugar de sobrescribir el valor en cada iteración.

```csharp
public double Total
{
    get
    {
        double total = 0;
        foreach (var arreglo in \_arregloflorales)
        {
            total += arreglo.ObtenerCostoArreglo(); // Se suma el costo
        }
        return total;
    }
}

public double DescuentoAplicado
{
    get
    {
        double descuento = 0;
        foreach (var arreglo in \_arregloflorales)
        {
            descuento += arreglo.ObtenerCostoArreglo() \* 0.10; // Se suma el descuento
        }
        return descuento;
    }
}
```

3. **_Mensajes de Excepción:_**
   Los mensajes de excepción no proporcionan información útil.
   Proporcionar mensajes descriptivos.

```csharp
if (_arregloflorales == null)
{
    throw new InvalidOperationException("No hay arreglos florales en el pedido.");
}
```

5. **_Método MostrarResumenPedido:_**
   El método MostrarResumenPedido estaba incompleto.
   Completar el método para mostrar un resumen detallado del pedido.

```csharp
public void MostrarResumenPedido()
{
    Console.WriteLine($"Cliente: {Nombre}");
    Console.WriteLine($"Total del pedido: {pedido.Total:C}");
    Console.WriteLine($"Descuento aplicado: {pedido.DescuentoAplicado:C}");
    Console.WriteLine($"Monto final a pagar: {(pedido.Total - pedido.DescuentoAplicado):C}");
}
```

6. **_Uso de la Clase Pedido:_**
   En el constructor de la clase Cliente, se está creando una nueva instancia de Pedido en lugar de usar el objeto que se pasa como parámetro.
   Asignar correctamente el pedido pasado como parámetro.

```csharp
public Cliente(string nombre, Pedido pedido)
{
    this.pedido = pedido; // Usar el parámetro en lugar de crear un nuevo objeto
    Nombre = nombre;
}
```

7. **_Pruebas en el Programa Principal:_**
   El Main no muestra el flujo completo del programa.
   Se debería completa el Main para probar el flujo del programa y mostrar los resultados.

```csharp
using Floreria.Modelos;

class Program
{
    static void Main()
    {
        // Crear flores
        Flor flor1 = new Flor("Rosa", 100);
        Flor flor2 = new Flor("Lirio", 150);

        // Crear arreglo floral
        ArregloFloral arregloFloral = new ArregloFloral();
        arregloFloral.AgregarFlor(flor1);
        arregloFloral.AgregarFlor(flor2);

        // Crear pedido
        Pedido pedido = new Pedido();
        pedido._arregloflorales.Add(arregloFloral);  // Agregar el arreglo floral al pedido

        // Crear cliente y asignar pedido
        Cliente cliente = new Cliente("Ismael", pedido);

        // Mostrar el resumen del pedido
        cliente.MostrarResumenPedido();
    }
}
```

### Evaluación General:

El código tiene una base sólida en términos de estructura y encapsulamiento, y la lógica principal está en su lugar. Sin embargo, varios errores de lógica y detalles menores afectan la funcionalidad del sistema.

### Puntaje Total: _1 / 3_

_Observación Final: El proyecto tiene un buen punto de partida, pero requiere algunas correcciones para funcionar correctamente en la gestión de pedidos y arreglos florales._

---

### Ejercicio 3:

### Diagrama.

#### Observaciones

1. **_Diagrama por defecto que te da el programa al crear uno nuevo, diagrama no válido._**

#### Código:

#### Puntos Positivos:

    ✅ Modelado Correcto de Clases
    ✅ Encapsulamiento de Datos
    ✅ Constructor Correcto

#### Observaciones y Mejoras:

1. **_Asignación Incorrecta de LugarDisponible:_**
   En el método ConsultarLugar, la variable LugarDisponible siempre se establece en 0 antes de incrementarse en 1 si la clase está disponible. Esto no tiene sentido lógico y debe corregirse para reflejar la cantidad real de lugares disponibles.
   En lugar de asignar 0 y luego sumar 1, debe reducir el número de lugares disponibles a medida que los miembros se registran, o mostrar el número correcto de lugares.

```csharp
public void ConsultarLugar()
{
    if (LugarDisponible > 0)
    {
        Console.WriteLine($"Lugares disponibles: {LugarDisponible}");
    }
    else
    {
        Disponibilidad = false;
        Console.WriteLine("No hay lugares disponibles.");
    }
}
```

2. **_Asignación Incorrecta en el If:_**
   En el condicional if (Disponibilidad = true), se está utilizando el operador de asignación = en lugar del comparador de igualdad ==, lo que provoca que siempre se evalúe como verdadero.

```csharp
if (Disponibilidad == true)
```

3. **_Uso Incorrecto de Métodos en Main:_**
   El código intenta usar un método Add en las instancias de Instructor y Miembro, lo cual es incorrecto. No se puede agregar un objeto Clase a un Instructor o Miembro directamente. En lugar de eso, podrías crear una relación adecuada donde el Instructor gestione sus clases, y los Miembros se inscriban en ellas.
   Implementar una lista en la clase Instructor para almacenar las clases que imparte, y en la clase Miembro para las clases a las que asiste.

```csharp
public class Instructor
{
    public List<Clase> Clases { get; private set; } = new List<Clase>();

    public void AgregarClase(Clase clase)
    {
        Clases.Add(clase);
    }

}

public class Miembro
{
    public List<Clase> Clases { get; private set; } = new List<Clase>();

    public void InscribirseEnClase(Clase clase)
    {
        Clases.Add(clase);
    }

}
```

4. **_Parámetro LugarDisponible no Asignado en Constructor:_**
   En el constructor de la clase Clase, el parámetro lugardisponible no está siendo asignado a la propiedad correspondiente.

```csharp
public Clase(Instructor instructor, double costo, int lugardisponible)
{
    Instructor = instructor;
    Costo = costo;
    Disponibilidad = true;
    LugarDisponible = lugardisponible;
}
```

5. **_Falta de Manejo de Inscripciones de Miembros a Clases:_**
   No se maneja la lógica para reducir el número de lugares disponibles cuando un miembro se inscribe en una clase. Se debería incluir esta funcionalidad para reflejar la cantidad de lugares ocupados y disponibles correctamente.
   Añadir una función en Clase para manejar las inscripciones y reducir el número de lugares disponibles.

```csharp
public void InscribirMiembro(Miembro miembro)
{
    if (LugarDisponible > 0)
    {
        LugarDisponible--;
        Console.WriteLine($"{miembro.Nombre} se ha inscrito en la clase.");
    }
    else
    {
        Console.WriteLine("No hay más lugares disponibles.");
    }
}
```

### Evaluación General:

El código muestra un buen intento de modelar un sistema para gestionar un gimnasio con clases, instructores y miembros. Sin embargo, hay varios errores lógicos que impiden su correcto funcionamiento, desde errores en asignaciones de variables hasta el uso incorrecto de métodos no existentes. Además, faltan algunas funcionalidades esenciales como la gestión de inscripciones y la actualización de la disponibilidad.

#### Puntaje Total: _1 / 4_

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
    <td align="center">1</td>
    <td align="center">1</td>
    <td align="center">4</td>
    <td align="center">Desaprobado</td>
  </tr>
</table>
