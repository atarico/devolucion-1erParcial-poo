## Diagrama:

Faltan métodos para trabajar con asignaciones y agregar elementos a las listas.
Si la relación entre `Vehículo` y `Cliente` es bilateral, no debería haber una flecha indicando una unilateralidad; además esta relación sería una de tipo Agregación/Composición.
En la clase `TarbajoReparacion`a la propiedad `TipoTrabajo` le falta su tipo.
La clase `TallerMecanico` no es necesaria y no se marca una relación concreta con alguna otra clase.

#### 4/5

---

## Código:

#### Puntos Positivos

- Enumeración TipoTrabajo más clara y descriptiva
- Buena implementación de propiedades con encapsulamiento
- Relaciones entre clases mejor definidas
- Uso apropiado de listas para manejar colecciones

#### Observaciones y mejoras:

1. **_Clase Cliente:_**

```csharp
public class Cliente
{
    // El método MostrarDetallesCliente está mal implementado
    public void MostrarDetallesCliente()
    {
        Console.WriteLine($"Cliente: {Nombre} (Nº {NroCliente})");
        foreach(var vehiculo in Vehiculos)
        {
            vehiculo.MostrarDetallesVehiculo(); // Mostrar detalles de cada vehículo
        }
    }

    // Falta método para agregar vehículos
    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        if (vehiculo == null)
            throw new ArgumentNullException(nameof(vehiculo));
        Vehiculos.Add(vehiculo);
    }

}
```

Clase TrabajoReparacion:

csharpCopypublic class TrabajoReparacion
{
// Constructor incompleto - no asigna TipoTrabajo
public TrabajoReparacion(Mecanico mecanico, TipoTrabajo tipoTrabajo, double costo)
{
Mecanico = mecanico ?? throw new ArgumentNullException(nameof(mecanico));
TipoTrabajo = tipoTrabajo;
// El parámetro costo no se usa ya que CostoTrabajo es calculado
}

    // Mejorar el método MostrarDetallesReparacion
    public void MostrarDetallesReparacion()
    {
        Console.WriteLine($"Trabajo de {TipoTrabajo} realizado por {Mecanico.Nombre}");
        Console.WriteLine($"Costo total: ${CostoTrabajo:N2}");
    }

}

2. **_Clase Vehiculo:_**

```csharp
public class Vehiculo
{
    // Agregar método para registrar trabajos
    public void AgregarTrabajo(TrabajoReparacion trabajo)
    {
        if (trabajo == null)
        throw new ArgumentNullException(nameof(trabajo));
        Trabajo.Add(trabajo);
    }

    // Mejorar MostrarDetallesVehiculo para incluir trabajos
    public void MostrarDetallesVehiculo()
    {
        Console.WriteLine($"Vehiculo: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Año: {Año}");
        Console.WriteLine($"Propietario: {Cliente.Nombre}");

        if (Trabajo.Any())
        {
            Console.WriteLine("\nHistorial de trabajos:");
            foreach (var trabajo in Trabajo)
            {
                trabajo.MostrarDetallesReparacion();
            }
        }
    }

}
```

3. **_Program.cs:_**

```csharp
class Program
{
    static void Main()
    {
        // Agregar manejo de excepciones
        try
        {
            Cliente benjamin = new Cliente("Benjamin", 159357);
            // Agregar los vehículos a la lista del cliente
            benjamin.AgregarVehiculo(auto);
            benjamin.AgregarVehiculo(camioneta);

            // Agregar el trabajo al vehículo
            auto.AgregarTrabajo(trabajito);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}
```

#### 4/5

### Evaluación general:

#### 8/10
