## Diagrama:

Faltan parámetros a los métodos de asignación; ¿sino como sé que debo asignar a qué?
Un `Trabajo` puede ser realizado por más de un `Mecánico`. Si la respuesta es ‘SI’, la propiedad dentro de `Trabajo` debe ser una lista.
Al trabajar con listas se debe tener en cuenta la posibilidad de usar relaciones de tipo Agregación o Composición, especialmente cuando usas una cardinalidad “`1…*`”.

#### 5/5

---

## Código:

#### Observaciones y Mejoras:

1. **_Clases Incompletas y Falta de Propiedades:_**
   Las clases TipoEspecialidad, Tiporeparacion, Cliente, mecanico y Vehiculo están completamente vacías. Esto hace que el código no compila, ya que se intenta acceder a propiedades y métodos que no existen en estas clases.

2. **_Uso Incorrecto de Tiporeparacion en Trabajo:_**
   En la clase Trabajo, la propiedad tiporeparacion está mal implementada: intenta actuar como un método o propiedad con lógica compleja sin definición clara.

3. **_Inconsistencia en el Uso de TipoEspecialidad:_**
   En el método AsignarMecanico, TipoEspecialidad se utiliza incorrectamente como si fuera una propiedad del mecanico. Sin embargo, TipoEspecialidad debería ser una propiedad en mecanico o recibir el valor al instanciarse.

4. **_Problemas en el Modificador de Acceso de las Clases:_**
   Las clases Vehiculo y mecanico están marcadas como internal, lo que restringe su acceso fuera de su namespace. Dado que estas clases serán usadas ampliamente, sería preferible definirlas como public.

5. **_Agregar Enumeración TipoEspecialidad:_**
   No se encuentra la definición para TipoEspecialidad. Se podría agregar como un enum en el archivo de mecanico.

#### 0/5

### Evaluación General:

#### 5/10
