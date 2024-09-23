### Buron, Devolución:

### Ejercicio 1:

### Puntos Positivos

- ✅ Organización del código
- ✅ Uso de encapsulamiento
- ✅ Interacción del usuario

### Mejoras Necesarias

1.  **_Error en el cálculo de costos_**

    El bloque de código para calcular el costo total del arreglo floral está comentado y, además, tiene errores en su implementación.
    El foreach debería recorrer `_flores`, no `Flor`, y en lugar de `flor.costo++`, debería sumar el Costo de cada flor:

```csharp

 public double CostoTotalArreglo
 {
     get
    {
        double costoTotal = 0;
        foreach (var flor in _flores)
    {
    costoTotal += flor.Costo;
    }
        return costoTotal;
    }
 }
```

2.  **_Instancias de Flor en el switch no se usan_**

    Dentro del switch, se crean instancias de Flor pero no se están utilizando después. Estas instancias se pierden y no se agregan a ninguna lista ni se usan en el flujo del programa.
    Deberías crear una lista para almacenar las flores seleccionadas y luego agregarlas al arreglo floral.

```csharp

List<Flor> floresEncargadas = new List<Flor>();
switch (encargo)
{
    case 1:
    floresEncargadas.Add(new Flor("Margarita", 15));
    break;
    case 2:
    floresEncargadas.Add(new Flor("Clavel", 13));
    break;
    case 3:
    floresEncargadas.Add(new Flor("Tulipan", 22));
    break;
    case 4:
    floresEncargadas.Add(new Flor("Estrella Federal", 17));
    break;
    case 5:
    floresEncargadas.Add(new Flor("Aloe Vera", 12));
    break;
}
```

3.  **_Agregar las flores al arreglo floral_**

    Debes crear una instancia de ArregloFloral y agregar las flores que seleccionó el usuario.

4.  **_El pedido no está sumando los arreglos_**

    El constructor de Pedido está recibiendo solo un total pero no está considerando los arreglos florales. Debería haber un método para agregar arreglos florales al pedido y calcular el costo total basado en esos arreglos.

```csharp
public class Pedido
{
    private List<ArregloFloral> _arregloFloral = new List<ArregloFloral>();
    public void AgregarArreglo(ArregloFloral arreglo)
    {
        _arregloFloral.Add(arreglo);
    }
    public double Total
    {
        get
        {
            double total = 0;
            foreach (var arreglo in _arregloFloral)
            {
                total += arreglo.CostoTotalArreglo;
            }
            return total;
        }
    }
}
```

5.  **_Salida en `MostrarDetallesPedido`_**

    En el método `MostrarDetallesPedido` de la clase `Cliente`, actualmente solo estás imprimiendo la referencia del objeto `Pedido` en lugar de sus detalles. Deberías hacer que el `Pedido` muestre sus detalles relevantes.

```csharp
public void `MostrarDetallesPedido`()
{
    Console.WriteLine($"Cliente {Nombre}");
    Console.WriteLine($"Total del pedido: {Pedido.Total}");
}
```

6.  **_Formato y Convenciones de Nombre_**

    Es recomendable usar mayúsculas en los nombres de las clases y métodos, por lo que el nombre de la clase program debería ser Program.

7.  **_Métodos redundantes_**

El campo `Total` en `Pedido` podría eliminarse si calculas el total a partir de los arreglos florales. Esto evita almacenar datos que pueden volverse inconsistentes.

### Evaluación Final:

El código tiene una estructura bien organizada y un concepto claro, pero existen algunos errores lógicos y sintácticos que deben corregirse para mejorar

#### Puntaje **total: 1.5 / 3 pts**

---

### Ejercicio 2:

**No completado**

### Evaluación Final:

Se crearon las clases `Miembro`, `Instructor` y `Clase` pero no se le agregaron métodos.
Se crea la clase `Program` con el `Main` pero no se ejecuta nada dentro de la función.

#### Puntaje **total: 0 / 4 pts**

---
