## Diagrama:

Al trabajar con listas se debe considerar la relación de tipo Agregación/Composición.
La relación entre `Mecánico` y `Trabajo` podría ser de tipo Asociación ya que un mecánico puede hacer más de un trabajo.

5/5

---

## Código:

#### Puntos Positivos

- Excelente uso de enumeraciones para Especialidad y Servicios
- Buena organización del código en namespaces y modelos
- Implementación correcta de cálculo de costos totales
- Buena separación de responsabilidades entre clases
- Relaciones entre clases bien definidas

#### Observaciones y mejoras:

1. **_Clase Cliente:_**

```csharp
public class Cliente
{
    // Agregar nombre del cliente
    public string Nombre { get; private set; }

    // Validación en constructor
    public Cliente(int codigo, string nombre)
    {
        if (codigo <= 0)
            throw new ArgumentException("El código debe ser positivo");
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío");

        Codigo = codigo;
        Nombre = nombre;
    }

    // Mejorar método Detalles
    public void Detalles()
    {
        Console.WriteLine($"\nDetalles del Cliente {Codigo}:");
        if (!VehiculoCliente.Any())
        {
            Console.WriteLine("No tiene vehículos registrados.");
            return;
        }

        foreach (var vehiculo in VehiculoCliente)
        {
            Console.WriteLine($"Vehículo: {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Año})");
            Console.WriteLine($"Total en reparaciones: ${vehiculo.TotalArreglos:N2}");
        }
    }

}
```

2. **_Clase Vehiculos:_**

```csharp
public class Vehiculos // Mejor nombrar en singular: Vehiculo
{
    // Agregar validaciones
    public Vehiculos(string marca, string modelo, int año)
    {
        if (string.IsNullOrWhiteSpace(marca))
        throw new ArgumentException("La marca no puede estar vacía");
        if (string.IsNullOrWhiteSpace(modelo))
        throw new ArgumentException("El modelo no puede estar vacío");
        if (año < 1886 || año > DateTime.Now.Year + 1)
        throw new ArgumentException("Año inválido");

        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    // Agregar método para mostrar historial
    public void MostrarHistorialServicios()
    {
        Console.WriteLine($"\nHistorial de servicios para {Marca} {Modelo}:");
        foreach (var trabajo in Servicio)
        {
            trabajo.MostrarDetalles();
        }
        Console.WriteLine($"Total acumulado: ${TotalArreglos:N2}");
    }

}
```

3. **_Program.cs:_**

```csharp
class Program
{
    static void Main()
    {
        try
        {
            // Usar constantes para los costos
            const double COSTO_ARREGLO_LUCES = 200;
            const double COSTO_CAMBIO_ACEITE = 50;
            const double COSTO_PINTURA = 500;

            // Inicialización con manejo de errores
            var cliente1 = new Cliente(24, "Juan Pérez");
            var mecanico1 = new Mecanico(Especialidad.MecanicaGeneral);
            var trabajo = new Trabajo(Servicios.CambioDeAceite, COSTO_CAMBIO_ACEITE);

            // Verificar especialidad antes de asignar trabajo
            if (trabajo.VerificarEspecialidad(mecanico1, trabajo.Descripcion))
            {
                // Asignar trabajo
            }
            else
            {
                Console.WriteLine("No se puede asignar el trabajo - especialidad incorrecta");
            }
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
