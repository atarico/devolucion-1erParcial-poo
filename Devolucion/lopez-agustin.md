### Ejercicio 2:

#### Puntos Positivos:

    ✅Modularidad
    ✅Uso de listas
    ✅Lógica de descuentos

#### Correcciones y Mejoras

1. **_Problema con la recursión infinita en la propiedad Costo de la clase Flor:_** Actualmente, la propiedad Costo utiliza Costo = value; en su set, lo cual generaría una llamada infinita al setter de la misma propiedad. Para solucionarlo, deberías utilizar un campo privado para almacenar el valor de Costo. Aquí la corrección:

```csharp
class Flor
{
    private string Tipo;
    private double costo;
    public double Costo { get { return costo; } private set { costo = value; } }

    public Flor(string tipo, double costo)
    {
        Tipo = tipo;
        Costo = costo;
    }
}
```

2. **_Corrección en la clase ArregloFloral:_**
   Hay un error en la línea florsum =+ flor.Costo;. Esto no suma correctamente los costos, sino que reasigna el valor de florsum a flor.Costo. La expresión correcta es florsum += flor.Costo;.

3. **_Aquí está la versión corregida del método ObtenerCostoArreglo:_**

```csharp
public double ObtenerCostoArreglo()
{
    double florsum = 0;
    foreach (Flor flor in Florerio)
    {
        florsum += flor.Costo;
    }
    return florsum;
}
```

4. **_Corrección en la clase Pedido:_**
   El constructor de la clase Pedido es privado, lo que significa que no podrás instanciar objetos de esta clase fuera de la misma. Para solucionar esto, debes hacer el constructor public.

```csharp
class Pedido
{
    public List<ArregloFloral> Pedidito = new List<ArregloFloral>();

    public Pedido(ArregloFloral arregloFloral)
    {
        Pedidito.Add(arregloFloral);
    }
}
```

5. **_Corrección en la clase Cliente:_**
   El constructor de la clase Cliente también es privado. Para permitir la creación de instancias de la clase, el constructor debe ser público.
   El cálculo del descuento está incorrecto en la línea SumaTotal _ 0.1. Esto aplica solo el 10% del costo, cuando en realidad deberías restar el 10%. La fórmula correcta es SumaTotal _ 0.9 para aplicar un descuento del 10%.

```csharp
class Cliente
{
    private string Nombre;
    private Pedido Pedilo;

    public Cliente(string nombre, Pedido pedilo)
    {
        Nombre = nombre;
        Pedilo = pedilo;
    }

    public void MostrarResumenPedido()
    {
        int i = Pedilo.Pedidito.Count;
        double SumaTotal = 0;
        bool DescuentoAplicable = i >= 5;

        foreach (ArregloFloral arreglo in Pedilo.Pedidito)
        {
            SumaTotal += arreglo.ObtenerCostoArreglo();
        }

        if (DescuentoAplicable)
        {
            Console.WriteLine($"El precio sumado de los arreglos pedidos es: {SumaTotal}. Debido a tener un descuento por cantidad, el precio final es {SumaTotal * 0.9}.");
        }
        else
        {
            Console.WriteLine($"El precio final por los arreglos pedidos es: {SumaTotal}. ");
        }
    }

}
```

6. **_Clase Program:_** Finalmente, puedes agregar una clase Program para inicializar los objetos y ejecutar el código.

### Evaluación General:

El código está bien estructurado y tiene una lógica clara en cuanto al manejo de las flores y arreglos florales. Sin embargo, hay problemas técnicos que impiden el correcto funcionamiento, como la recursión infinita en la propiedad Costo, errores en operadores y accesibilidad de los constructores. Además de que no existe la clase Program con su Main para ejecutar el código

#### Puntaje Total: 1 / 3

---

### Ejercicio 3:

### Código:

### Puntos Positivos:

    ✅ Organización del código
    ✅ Lógica básica de inscripción/desinscripción

### Observaciones y Mejoras:

1. **_Constructores privados:_** Los constructores de las clases Miembro, Instructor, y Clase son privados, lo que impide crear instancias de estas clases desde fuera de la misma clase. Deben ser públicos para permitir la creación de objetos.

```csharp
class Miembro
{
    private string Nombre;
    private int CodigoMiembro;

    // Constructor ahora es público
    public Miembro(string nombre, int codigoMiembro)
    {
        Nombre = nombre;
        CodigoMiembro = codigoMiembro;
    }
}
```

Lo mismo para el resto de las clases.

2. **_Recursión en las propiedades:_** La propiedad LugaresDisponibles tiene un problema de recursión infinita porque tanto el getter como el setter están asignando a sí mismos en lugar de un campo privado. Se debe declarar un campo privado como respaldo para evitar este problema.

```csharp
class Clase
{
    private int _lugaresDisponibles;

    public int LugaresDisponibles
    {
        get { return _lugaresDisponibles; }
        set { _lugaresDisponibles = value; }
    }

    public Clase(double costoClase, int lugaresDisponibles, Instructor instructorAsignado)
    {
        CostoClase = costoClase;
        _lugaresDisponibles = lugaresDisponibles;
        InstructorAsignado = instructorAsignado;
    }
}
```

3. **_Sobrecarga de constructores en Instructor:_** El constructor que recibe una clase no debería sobreescribir el constructor principal. Debería usarse sobrecarga para evitar confusiones en la creación de objetos.

```csharp
class Instructor
{
    private string Nombre;
    private string Experiencia;
    List<Clase> ClasesAsignadas = new List<Clase>();

    // Constructor principal
    public Instructor(string nombre, string experiencia)
    {
        Nombre = nombre;
        Experiencia = experiencia;
    }

    // Constructor sobrecargado que recibe una clase
    public Instructor(string nombre, string experiencia, Clase clase)
    {
        Nombre = nombre;
        Experiencia = experiencia;
        ClasesAsignadas.Add(clase);
    }
}
```

4. **_Accesibilidad y encapsulación:_** Las variables como Nombre, Experiencia, y CostoClase deberían tener propiedades públicas (con campos privados de respaldo) para permitir acceso controlado desde otras clases.

5. Falta la clase Program: Lo que impide la ejecución del código en generañ

### Evaluación General:

El código tiene una estructura inicial sólida, pero presenta varios problemas técnicos relacionados con la accesibilidad de los constructores y el manejo de propiedades. Además, se debe mejorar el manejo de errores y corregir la recursión en las propiedades.

#### Puntaje Total: 1 / 4

_Tiene potencial, pero requiere ajustes en los constructores, manejo de propiedades, y excepciones para ser funcional._

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
    <td align="center">1</td>
    <td align="center"></td>
    <td align="center">Desaprobado</td>
  </tr>
</table>
