### Albitre, Devolución:

#### Ejercicio 2:

#### Puntos Positivos

- ✅ Sintaxis clara
- ✅ Uso de propiedades privadas
- ✅ Uso de listas
- ✅ Modularidad y encapsulamiento

_Los métodos para mostrar detalles (MostrarDetallesFlor, MostrarDetallesArreglo, MostrarDetallesPedido) están bien pensados y ayudan a mantener todo bien organizado._
<br>

#### Observaciones y mejoras:

1. **_Error en la propiedad Total en Pedido:_**
   En el getter de la propiedad Total, hay un problema de referencia circular. Estás calculando `costoTotal`, pero después tratas de retornar `Total`, lo que haría que se vuelva a ejecutar el getter y puede que entre en un bucle infinito. Deberías devolver `costoTotal`.

```csharp

public double Total
{
    get
    {
        double costoTotal = 0;
        foreach(ArregloFloral arreglo in _arreglosFlorales)
        {
            costoTotal += arreglo.ObtenerCosto();
        }
        return costoTotal;
    }
}
```

<br>

2. **_Uso innecesario de System.Linq y System.Text:_**
   No estás usando los espacios de nombres System.Linq ni System.Text, así que podés eliminarlos para limpiar el código.

3. **_Constructor vacío en Pedido y ArregloFloral no son necesarios:_**
   Los constructores vacíos en Pedido y ArregloFloral podés sacarlos si no vas a agregar lógica extra.

4. **_No se usa el valor de retorno de ObtenerCosto:_** En el Main, estás llamando a ObtenerCosto(), pero no haces nada con el valor devuelto.

```csharp
double costoArreglo1 = arreglo1.ObtenerCosto();
Console.WriteLine($"Costo total del arreglo 1: {costoArreglo1}");
```

### Evaluación general:

El código tiene una buena estructura y está bien organizado. Buena comprensión de los conceptos de orientación a objetos

**¡Muy buen trabajo!**

#### Puntaje total: **3 / 3pts**

---

### Ejercicio 2:

#### Aspectos positivos:

- ✅ Buena estructuración
- ✅ Uso de encapsulamiento
- ✅ Lógica clara y fácil de seguir

#### Observaciones y mejoras:

1. **_Validación en ActualizarLugares:_**
   No se está validando si quedan lugares disponibles antes de reducir el número de `LugaresDisponibles`. Sería conveniente agregar una verificación para evitar que el valor se vuelva negativo.

2. **_Validación en la inscripción de clases:_**
   En la clase Miembro, en el método `InscribirseAClase`, podrías validar si el miembro ya está inscrito en la clase para evitar inscripciones duplicadas.

3. **_Nombres de variables:_**
   El nombre de la variable `Numero` en la clase Miembro no es muy descriptivo. Podrías cambiarlo a algo más específico, como `NumeroMiembro` para mejorar la claridad.

4. **_Constructor de Clase:_**
   Podrías agregar validaciones en el constructor de Clase para asegurarte de que los parámetros como lugares y costo no sean negativos.

```csharp
public Clase(string nombre, int lugares, double costo, Instructor instructor)
{
    if (lugares < 0 || costo < 0)
    {
        throw new ArgumentException("Lugares y costo deben ser valores positivos.");
    }
    NombreClase = nombre;
    LugaresDisponibles = lugares;
    Costo = costo;
    InstructorCl = instructor;
}
```

En general, el código es claro y funcional, pero con estas pequeñas mejoras podría volverse más

robusto y fácil de mantener. ¡Buen trabajo!

### Evaluación general:

En general, el código es claro y funcional, pero con estos pequeños agregados podría mejorar

**¡Muy buen trabajo!**

#### Puntaje total: **4 / 4 pts**

---
