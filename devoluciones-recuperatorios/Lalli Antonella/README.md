## Diagrama:

Faltan parámetros a algunos métodos.
Un `Mecánico` debería estar asociado a un `ServicioDeTrabajo`.
Si se está trabajando con listas es necesario considerar las relaciones de tipo Agregación o Composición dependiendo el caso.

#### 4/5

---

## Código:

#### Puntos Positivos

- Organización de namespaces
- Encapsulamiento y acceso a propiedades
- Uso de listas

#### Observaciones y Mejoras

1.  **_Redundancia en definiciones de clases:_** La clase ServicioDeTrabajo y Vehiculo están duplicadas en el código. Esto puede causar errores de compilación.
2.  **_Declaración de serviciosRealizados:_** El acceso público a la lista serviciosRealizados de Vehiculo no es seguro y podría llevar a modificaciones accidentales.

```csharp
private readonly List<ServicioDeTrabajo> serviciosRealizados = new List<ServicioDeTrabajo>();

public IReadOnlyList<ServicioDeTrabajo> ServiciosRealizados => serviciosRealizados;
```

3. **_Validación del año en Vehiculo:_** La propiedad Año podría beneficiarse de una validación para asegurar que el año esté dentro de un rango válido.

```csharp
public Vehiculo(string marca, string modelo, int año, string patente)
{
    Marca = marca;
    Modelo = modelo;
    Patente = patente;
    Año = (año > 1900 && año <= DateTime.Now.Year) ? año : throw new ArgumentException("Año inválido.");
}
```

4.  **_Posible excepción no controlada en AsignarMecanico:_** La excepción lanzada en AsignarMecanico puede interrumpir el flujo si no se controla adecuadamente.

```csharp
try
{
    servicio.AsignarMecanico(mecanico);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
```

#### 4/5

### Evaluación General

#### 8/10
