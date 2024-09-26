### Ejercicio 1:

#### Análisis

- ✅ Relaciones correctas

#### Observaciones

1. **_Saber próximo mantenimiento:_**
   La empresa desea saber cuándo se va realizar el siguiente mantenimiento de un vehículo, para ello haría falta un método `CalcularProximoMantenimiento()` en la clase `SupervisorFlota` por ejemplo.

2. **_Relación entre `Conductor` y `Vehiculo`:_**
   La cardinalidad con respecto a `Conductor` no es correcta, un `Vehiculo` debe estar asignado a un o ningún `Conductor` en un momento dado de su estado. Falta la propiedad que represente este estado, vehículo en `Conductor` o conductor en `Vehículo`.

3. **_Dependencia`:_**
   Falta indicar para que sentido 'va' la dependencia entre `SupervisorFlota` y `Vehículo`.

4. **_Camión y autobús:_**
   Hay atributos en común que se podrían compartir en una superclase sin necesidad de ponerlas individualmente (fechaMantenimiento, UltimaCantKilometros, nombre)

#### Puntaje total: _1.5 / 3_

---

### Ejercicio 2:

**No completado**

### Evaluación Final:

Se crearon las clases `Flor`, `ArregloFloral` y `Pedido`, no se creo la clase `Cliente`.
Se crea la clase `Program` con el `Main` pero no se ejecuta nada dentro de la función.

#### Puntaje total: _0 / 3_

---

### Ejercicio 3:

### Diagrama.

#### Observaciones

1. **_Relaciones:_**
   Falta cardinalidad en las relaciones y algunas no tienen coherencia.

2. **_Propiedades/atributos:_**
   Cuidado con los nombres de los atributos en las clases, si no se usa una lista no es necesario nombrarlos en plural.

### Evaluación Final:

Se crearon las clases `Miembro`, `Instructor` y `Clase` pero no se completaron en su totalidad.

#### Puntaje total: _1.5 / 4_

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
    <td align="center">0</td>
    <td align="center">1.5</td>
    <td align="center">3</td>
    <td align="center">Desaprobado</td>
  </tr>
</table>
