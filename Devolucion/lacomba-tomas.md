### Lacomba Tomas, Devolución:

#### Ejercicio 1:

#### Observaciones

1. **_Falta una entidad:_**
   Falta la principal función del sistema que es hacer mantenimientos a los vehículos y calcular el próximo mantenimiento, para ello era necesario involucrar a otra entidad.

2. **_Sintaxis:_**
   Algunas sintaxis con respecto a los diagramas de clases no son correctas, especialmente en los métodos.

### Evaluación general:

Algunas partes de la tipificación no son las más convenientes.
Falta la propiedad que represente el estado entre vehículo y conductor, vehículo en `Conductor` o conductor en `Vehículo`.

#### Puntaje total: **1 / 3pts**

#### Ejercicio 2:

#### Puntos Positivos

- ✅ Uso correcto de clases para representar Flor, ArregloFloral y Pedido
- ✅ Implementación adecuada de cálculos de costos y descuentos
- ✅ Uso de decimal para valores monetarios

#### Observaciones y mejoras:

1. **_Encapsulamiento:_**
   Las propiedades en las clases Flor, ArregloFloral y Pedido podrían beneficiarse de un mejor encapsulamiento:

```csharp
class Flor
{
    public string Tipo { get; private set; }
    public decimal Costo { get; private set; }

    public Flor(string tipo, decimal costo)
    {
        Tipo = tipo;
        Costo = costo;
    }
}
```

2. **_Validaciones:_**
   Añadir validaciones en los constructores o métodos para asegurar que los valores sean válidos.

#### Puntos Negativos:

1. No se usa Modularización
2. No se usó encapsulamiento
3. El programa no muestra el detalle de las flores.
4. El programa no muestra el detalle de los arreglos florales.

### Evaluación general:

El programa se ve bien. Faltaron aplicar 1 pilar fundamental de la programación orientada a objetos como lo es el encapsulamiento y realizar la modularización de las clases

**¡Buen trabajo!**

#### Puntaje total: **2 / 3 pts**

---

### Ejercicio 3:

## Diagrama.

#### Observaciones

1. **_Sintaxis y Tipificación:_**
   Lo mismo que en el anterior diagrama, la sintaxis no correcta en los métodos; y los tipos no son del todo correctos.

2. **_Relaciones:_**
   `Miembro` no tiene relación con `Instructor`. <br>
   Herencia desde miembro??

## Código.

#### Puntos Positivos

- ✅ Uso de constructores para inicializar objetos
- ✅ Implementación de lógica de inscripción
- ✅ Uso de decimal para valores monetarios

#### Observaciones y mejoras:

1. **_Manejo de errores:_**
   Considerar el uso de excepciones en lugar de mensajes de consola para manejar situaciones como clases llenas:

```csharp
public void InscribirseEnClase(Clase clase)
{
    if (clase.LugaresDisponibles > 0)
    {
        clase.ReducirLugares();
        Console.WriteLine($"{Nombre} se inscribió en la clase {clase.Nombre}.");
    }
    else
    {
        throw new InvalidOperationException($"No hay lugares disponibles en la clase {clase.Nombre}.");
    }
}
```

2. **_Validaciones:_**
   Añadir validaciones en los constructores:

```csharp
public Clase(string nombre, int lugaresDisponibles, decimal costo)
{
    if (string.IsNullOrWhiteSpace(nombre))
        throw new ArgumentException("El nombre de la clase no puede estar vacío.");
    if (lugaresDisponibles < 0)
        throw new ArgumentException("Los lugares disponibles no pueden ser negativos.");
    if (costo < 0)
        throw new ArgumentException("El costo no puede ser negativo.");

    Nombre = nombre;
    LugaresDisponibles = lugaresDisponibles;
    Costo = costo;

}
```

#### Puntos negativos:

1. **_Encapsulamiento y Modularización:_**
   Al igual que en el ejercicio anterior, las propiedades podrían beneficiarse de un mejor encapsulamiento y la modularización de clases
2. Mostrar por pantalla los detalles.

### Evaluación general:

El sistema de gimnasio muestra una buena estructura y separación de responsabilidades. Faltan algunos puntos importantes como el encapsulamiento y la modularización.

**¡Buen trabajo!**

#### Puntaje total: **2 / 4 pts**
