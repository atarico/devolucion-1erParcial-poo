namespace GimnasioLocal.Modulos
{
    public class Program
    {
        static void Main()
        {
            Instructor instructor1 = new Instructor("Juan Perez", 5);

            Clase clase = new Clase("Yoga", 20, 500);
            clase.AsignarInstructor(instructor1);

            Miembro miembro = new Miembro("Ismael", 1);
            miembro.InscribirseEnClase(clase);

            clase.MostrarDetalles();
        }
    }
}