## Diagrama:

Faltan propiedades para dar coherencia a las relaciones, por ejemplo, entre `vehículo` y `tarbajoReparacion`.
Faltan cardinalidades.
Hay muchas relaciones conjuntas que no tienen sentido.
Un mecánico solo se va a relacionar con el tarbajo/reparación que hace.
La clase `sistemaTaller` no es necesaria.
Faltan parámetros a algunos métodos.

2/5

---

## Código:

#### Puntos Positivos

- Encapsulamiento
- Organización
- Uso de IReadOnlyList
- Asignación de Mecánicos

#### Observaciones y Mejoras

1. **_Método MostrarVehiculosYTrabajos en Cliente:_** El método realiza un Console.WriteLine para cada trabajo, pero podrías usar un StringBuilder para optimizar la concatenación y facilitar su modificación o extensión en el futuro.

2. **_Control de Errores en AsignarMecanico:_** Si no hay mecánicos disponibles para el tipo de reparación solicitado, arroja una excepción genérica. Es recomendable definir una excepción específica, como NoMecanicoDisponibleException, para hacer el código más descriptivo y facilitar la depuración.

3. **_Propiedad Costo en TrabajoReparacion:_** Se podría calcular dinámicamente usando el tipo de reparación.

```csharp
public double Costo
{
    get
    {
        return tipo switch
        {
            TipoReparacion.Mecanica => 150,
            TipoReparacion.Electrica => 200,
            TipoReparacion.Pintura => 250,
            \_ => 100
        };
    }
}
```

4. **_Asignación de la Lista de Mecánicos:_** En la clase SistemaTaller, podrías validar si un cliente ya tiene un mecánico asignado antes de agregar uno nuevo.

### Evaluación General

**_Aprobado_**
