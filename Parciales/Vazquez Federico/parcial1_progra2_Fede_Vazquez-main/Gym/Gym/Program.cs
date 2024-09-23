using Gym.Models;

class Program
{
    static void Main()
    {
        Miembro miembro = new Miembro("Pepito");

        Instructor instructor = new Instructor("Jorgito", 5);

        Clase clase = new Clase(instructor, 2500, 5);
        clase.AgregarMiembro(miembro);

        clase.MostrarDetalles();
    }
}