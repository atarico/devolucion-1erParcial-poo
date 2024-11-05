namespace Punto3_Albitre.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor1 = new Instructor("Pedro", 10);
            Clase natacion = new Clase("Natacion", 20, 200, instructor1);
            Miembro miembro = new Miembro("Carla", 1);
            miembro.InscribirseAClase(natacion);
            natacion.ActualizarLugares();
            miembro.MostrarDetallesMiembro();
        }
    }
}