## Diagrama:

En la clase `Cliente`, el método `+AgregarVehiculo():void`. ¿Como sabe que vehículo debe agregar? Falta el parámetro. Y al tener una lista de vehículos se debe considerar una relación del tipo Agregación/Composición. ¿Un `Vehículo` puede tener muchos Clientes?
La relación entre`Mecánico`y`Vehículo` no es necesaria, el mecánico interactúa con un trabajo/reparación de un vehículo.
Falta por lo menos un `enum` para el tipo de trabajo/reparación que se hace.

3/5

---

## Código:

#### Puntos Positivos

- Implementación de numeración automática de clientes
- Buena organización del código en namespaces
- Métodos descriptivos para mostrar detalles
- Buena encapsulación con propiedades privadas
- Implementación correcta de relaciones entre clases

#### Observaciones y mejoras:

1. **_Clase Cliente:_**

```csharp
public class Cliente
{
    // La propiedad vehiculos no sigue convención de nombres (debería ser Vehiculos)
    public List<Vehiculo> Vehiculos { get; private set; } = new List<Vehiculo>();

    // El incremento del número de cliente podría causar problemas en un entorno multiusuario
    // Mejor implementación:
    private static readonly object _lock = new object();
    public int NumeroCliente
    {
        get
        {
            lock (_lock)
            {
                return ++Numero;
            }
        }
    }

    // Agregar validaciones
    public Cliente(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío", nameof(nombre));
        Nombre = nombre;
    }

}
```

2. **_Clase Trabajo:_**

```csharp
public class Trabajo
{
    // Mejor usar enum para TipoReparacion en lugar de string
    public enum TipoReparacion
    {
        CambioAceite,
        ReparacionElectrica,
        AjustesMotor
    }

    public TipoReparacion TipoTrabajo { get; private set; }

    // Mejorar el cálculo del costo total usando switch
    public double CostoTotal
    {
        get
        {
            return CostoFijo + TipoTrabajo switch
            {
                TipoReparacion.CambioAceite => 100,
                TipoReparacion.ReparacionElectrica => 200,
                TipoReparacion.AjustesMotor => 300,
                _ => 0
            };
        }
    }

    // Agregar validaciones en el constructor
    public Trabajo(double costoFijo, TipoReparacion tipoReparacion,
                  Mecanico mecanico, Vehiculo vehiculo)
    {
        if (costoFijo < 0)
            throw new ArgumentException("El costo no puede ser negativo");
        if (mecanico == null)
            throw new ArgumentNullException(nameof(mecanico));
        if (vehiculo == null)
            throw new ArgumentNullException(nameof(vehiculo));

        CostoFijo = costoFijo;
        TipoTrabajo = tipoReparacion;
        Mecanico = mecanico;
        Vehiculo = vehiculo;
    }
}
```

3. **_Clase Vehiculo:_**

```csharp
public class Vehiculo
{
    // Agregar validaciones para el año
    public Vehiculo(string marca, string modelo, int añoVehiculo)
    {
        if (string.IsNullOrWhiteSpace(marca))
        throw new ArgumentException("La marca no puede estar vacía");
        if (string.IsNullOrWhiteSpace(modelo))
        throw new ArgumentException("El modelo no puede estar vacío");
        if (añoVehiculo < 1886 || añoVehiculo > DateTime.Now.Year + 1)
        throw new ArgumentException("Año de vehículo inválido");

        Marca = marca;
        Modelo = modelo;
        AñoVehiculo = añoVehiculo;
    }

    // Agregar toString para mejor representación
    public override string ToString()
    {
        return $"{Marca} {Modelo} ({AñoVehiculo})";
    }

}
```

4. **_Program.cs:_**

```csharp
class Program
{
    static void Main()
    {
        try
        {
            // Usar constantes para valores fijos
            const double COSTO_FIJO_BASE = 300;

            // Inicialización y uso del sistema
            var cliente = new Cliente("Agustin");
            var vehiculo = new Vehiculo("RumRum", "Fium", 2025);
            var mecanico = new Mecanico("Ana", "Mecanica General");

            cliente.AgregarVehiculo(vehiculo);

            var trabajo = new Trabajo(COSTO_FIJO_BASE,
            Trabajo.TipoReparacion.CambioAceite,
            mecanico, vehiculo);

            // Mostrar información
            trabajo.MostrarDetalles();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en el sistema: {ex.Message}");
        }
    }
}
```

### Evaluación general:

**_Aprobado_**
