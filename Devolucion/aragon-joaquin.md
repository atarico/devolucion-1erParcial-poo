### Ejercicio 1:

#### Observaciones

1. **_Cardinalidades:_**
   Entre `Vehículo` y `Conductor`; un conductor puede manejar muchos o ningún vehículo, pero en la representación del estado de la clase, en un momento concreto puede manejar solo uno.

2. **_Relaciones:_**
   Un `Supervisor` no necesariamente debe tener un `NroLicencia`.
   Entre `Supervisor` y `Mantenimiento` no sería una relación de Agregación, sería una s de Asociación simplemente ya que no hay una relación del tipo ‘todo/parte’.

3. **_Saber próximo mantenimiento:_**
   La empresa desea saber cuándo se va realizar el siguiente mantenimiento de un vehículo, para ello haría falta un método `CalcularProximoMantenimiento()` por ejemplo.

### Evaluación general:

Hay relaciones y cardinalidades difíciles de entender y resultan ambiguas, como por ejemplo entre `Vehículo` y `Mantenimiento`; esta relación esta demás junto a la lista de mantenimientos dentro de `Vehículo`.
Las demás clases y relaciones están bien identificadas.

#### Puntaje total: _1.5 / 3_

---

### Ejercicio 2:

#### Puntos Positivos:

    ✅ Encapsulamiento Correcto
    ✅ Sobrecarga de Métodos
    ✅ Descuentos Dinámicos
    ✅ Modularización y Separación de Responsabilidades

#### Mejoras Sugeridas:

1. **_Uso Incorrecto de Pedido.Total en el Resumen de Pedido:_**
   En el método MostrarResumenPedido de la clase Cliente, estás sumando el total del pedido en cada iteración, lo que provoca que el total sea incorrecto. El total ya se calcula automáticamente en la propiedad Total de Pedido, por lo que no es necesario sumarlo de nuevo en el bucle.

```csharp
public void MostrarResumenPedido()
{
    Console.WriteLine($"Hola cliente {this.Nombre}. Preparando tu pedido...");
    Console.WriteLine("----------------------------------------------");
    // El total ya está calculado en Pedido.Total
    Console.WriteLine($"Sera un total de ${Pedido.Total} \n");
}
```

2. **_Sobrecarga de Método para Agregar Lista de Arreglos:_**
   La sobrecarga del método AñadirArregloFloral debería funcionar correctamente con listas. Para utilizarla, simplemente debes pasar una lista como argumento

```csharp
List<ArregloFloral> listaArreglos = new List<ArregloFloral>
{
    Arreglo1,
    Arreglo2,
    Arreglo3,
    Arreglo4,
    Arreglo5
};
pedido2.AñadirArregloFloral(listaArreglos);
```

3. **_Validación de Flores en RemoverFlor:_**
   Sería útil añadir una validación en el método RemoverFlor para manejar posibles errores si se intenta eliminar una flor que no está presente en la lista.

```csharp
public void RemoverFlor(Flor flor)
{
    if (Flores.Contains(flor))
    {
        Flores.Remove(flor);
    }
    else
    {
        Console.WriteLine("La flor no está en el arreglo.");
    }
}
```

4. **_Mejor Manejo de Salida:_**
   La salida en la consola puede mejorarse proporcionando detalles más legibles y organizados sobre los arreglos florales y sus costos, para que los clientes puedan ver mejor lo que están comprando.

### Evaluación General:

El código es muy funcional, pero requiere algunas mejoras en la claridad del flujo y manejo de datos. Las propiedades y métodos están bien diseñados, pero como en todo software, siempre hay cosas que mejorar.

**¡Muy Buen Trabajo!**

#### Puntaje Total: _3 / 3_

---

### Ejercicio 3

### Diagrama.

#### Análisis:

- ✅ Clases correctas.

#### Observaciones

1. **_Relación entre `Clase` e `Instructor`:_**
   No es Agregación debido a que `Instructor` no funciona como un ‘todo’ o ‘contenedor’ para las clases. En todo caso seria. En todo caso podría ser una Agregación si la relación fuera inversa (la clase contiene al instructor)

2. **_Relación entre `Clase` y `Miembro`:_**
   En el contexto actual, esta relación si es candidata a Agregación ya que una clase es la contenedora de miembros, por lo tanto, sería conveniente que `Clase` tenga una lista de miembros y no que `Miembro` tenga una lista de clases.
   PD: Esto también podría ser una relación de dependencia ya que `Miembro` solo hace uso de la `Clase` y en esta última solo cambia los lugares disponibles; y con esto último se concluye que `LugaresDisponibles` no debería ser una propiedad derivada.

#### Código:

#### Puntos Positivos:

    ✅ Estructura clara y bien organizada
    ✅ Manejo de listas
    ✅ Lógica para agregar y remover miembros
    ✅ Sobrecarga de métodos
    ✅ Encapsulamiento

#### Observaciones y Mejoras:

1. **_Evitar Inscripción Duplicada:_**
   Es recomendable evitar que un mismo miembro se inscriba más de una vez a la misma clase.
   Agregar una verificación en el método UniseClase para asegurarse de que el miembro no esté ya inscrito en esa clase.

```csharp
public void UniseClase(Clase clase)
{
    if (Clases.Contains(clase))
    {
        throw new ArgumentException("Ya estás inscrito en esta clase");
    }
    if (clase.LugaresDisponibles >= 1)
    {
        Clases.Add(clase);
        clase.QuitarLugar();
    }
    else
    {
        throw new ArgumentException("No hay espacios disponibles para anotarse a esta clase");
    }
}
```

2. **_Unificación de Idioma:_**
   El código alterna entre español e inglés, lo que puede generar confusión. Sería mejor unificar el idioma del código para mejorar la legibilidad.
   En lo posible, evitar el spanglish

### Evaluación General:

El código es sólido y con una sintaxis clara y entendible. Agregar un manejo adecuado de miembros y clases en el gimnasio, evitando duplicados y asignando correctamente los números de miembros.

**¡Excelente trabajo!**

#### Puntaje Total: _3.5 / 4_

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
    <td align="center">1.5</td>
    <td align="center">3</td>
    <td align="center">3,5</td>
    <td align="center">8</td>
    <td align="center">Aprobado</td>
  </tr>
</table>
