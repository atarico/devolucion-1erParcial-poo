/*Con el siguiente enunciado, elaborar un diagrama de clases y luego volcarlo a código (4pts):
En un pequeño gimnasio local, el administrador ha notado que con el aumento de miembros, el proceso de asignar instructores
a las clases y mantener un registro adecuado de las inscripciones se ha vuelto complicado. Los miembros pueden inscribirse en
varias clases, y cada clase tiene un instructor asignado. Además, para cada clase, el gimnasio necesita saber cuántos lugares
están disponibles y el costo por clase.

El administrador quiere un sistema en el que pueda llevar un control más organizado de las inscripciones. Los instructores deben
tener información básica como su nombre y experiencia, y cada miembro debe tener registrado su nombre y número de miembro. Cuando
un miembro se inscribe en una clase, el sistema debe reducir automáticamente el número de lugares disponibles.

Requisitos:
El gimnasio ofrece varias clases, y cada clase tiene un instructor asignado.
Los miembros del gimnasio pueden inscribirse en una o más clases.
Cada clase tiene un número limitado de lugares y un costo.
Los instructores tienen información básica, como nombre y experiencia.
Cuando un miembro se inscribe en una clase, se debe reducir la cantidad de lugares disponibles. */


/*  >MIEMBRO: string: Nombre, int: NroMiembro, Clases: Clase[]  / AgregarClaseAMiembro():void,  
    >CLASE: string: Nombre, int: Cupo, Miembros: Miembro[], Instructor: Instructor, double: Costo / ActualizarCupo(int cupo):int 
    (use nombre como diferenciador entre clases en vez de codigo, ej: nombre: Clase GAP 14hs)
    >INSTRUCTOR: string: Nombre, int: Experiencia  
    (use int para experiencia, ej: experiencia de 3 años) 
*/

namespace Ejercico3.Models;

class Program 
{
    static void Main() 
    { 
        /* INICIALIZAR INSTRUCTORES*/
        Instructor instructor1 = new Instructor("Dardo", 6);
        Instructor instructor2 = new Instructor("Moni",1);

        /* INICIALIZAR CLASES*/
        Clase claseGAP = new Clase("GAP 14hs",10, instructor1, 10.5);
        Clase claseYoga = new Clase("Yoga 16hs",2,instructor2, 12);

        /*INICIALIZAR MIEMBRO*/
        Miembro miembro1 = new Miembro("Maria Elena", 1);
        Miembro miembro2 = new Miembro("Coqui", 2);

        /*AGREGAR CLASES A LOS MIEMBROS SI HAY CUPO*/

        miembro1.AgregarClaseMiembro(claseGAP);
        miembro1.AgregarClaseMiembro(claseYoga);

        miembro2.AgregarClaseMiembro(claseYoga);

        /*MOSTRAR LOS DETALLES DE LAS CLASES Y LOS MIEMBROS*/
        miembro1.MostrarDetallesMiembro(miembro1.Clases);
        miembro2.MostrarDetallesMiembro(miembro2.Clases);

        claseGAP.MostrarDetallesClase();
        claseYoga.MostrarDetallesClase();

    }
}
