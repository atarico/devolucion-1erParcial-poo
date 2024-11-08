## Diagrama:

Un `Cliente` puede tener más de un `Vehículo` lo cual lleva a que esta relación sea de Agregación/Composición (se debe reflejar en las propiedades: `- Vehiculos: Vehículo[]`). Pasa lo mismo con las demás clases, faltan poner las respectivas propiedades para tener coherencia con las relaciones.
No era necesario una clase `Especialidad`.

#### 4/5

---

## Código:

#### Puntos Positivos:

- Uso de Enum para Tipos de Trabajo
- Encapsulamiento y Constructores
- Uso apropiado de listas para manejar colecciones

### Observaciones y Mejoras:

**_El código tiene multiples errores que no permiten su compilación._**

1.  **_Constructor Cliente en Main:_**
    El constructor de Cliente en Main está llamándose sin el parámetro Vehiculo, que es requerido en el constructor de Cliente.

```csharp
Cliente cliente1 = new Cliente("Ana", 1, auto1);
```

2. **_Errores en la Clase Mecanico:_**
   En el constructor Mecanico y en el método AgregarMecanico, se intenta añadir una instancia de Mecanico a su lista de Mecanicos pero de forma incorrecta. Además, Mecanico no debería recibir una instancia de sí misma en su constructor.

```csharp
public Mecanico(string nombre)
{
    Nombre = nombre;
}

public void AgregarMecanico(Mecanico mecanico)
{
    Mecanicos.Add(mecanico);
}
```

3. **_Problema en la Propiedad Costototal de Reparacion:_**
   La propiedad Costototal carece de un valor de retorno en todos los casos, lo que produce un error de compilación. Además, debería ser una propiedad de solo lectura (get), con el cálculo ajustado y una variable de retorno.

```csharp
public double Costototal
{
    get
    {
        double costoTotal = CostoFijo;
        switch (Trabajo)
        {
            case Trabajo.Electrico:
            costoTotal += 100;
            break;
            case Trabajo.Mecanico:
            costoTotal += 200;
            break;
            case Trabajo.Pintura:
            costoTotal += 150;
            break;
        }
        return costoTotal;
    }
}
```

4. **_Mensaje Incompleto en MostrarDetalle en Cliente:_**
   En el método MostrarDetalle de Cliente, Vehiculo no se muestra correctamente, ya que se está llamando al objeto en lugar de sus propiedades específicas.

```csharp
    public void MostrarDetalle()
    {
        Console.WriteLine($"El cliente número {NumCliente}, se llama {Nombre}, y tiene el vehículo {Vehiculo.Marca} modelo {Vehiculo.Modelo} del año {Vehiculo.Anio}");
    }
```

#### 2/5

### Evaluación General:

#### 6/10
