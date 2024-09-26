using Gimnasio.Models;

namespace Gimnasio
{
    public class Program
    {
        static void Main()
        {
            Miembro miembro1 = new Miembro("Nicolas", 7);
            Miembro miembro2 = new Miembro("Pablo", 2);
            Miembro miembro3 = new Miembro("Tomas", 3);

            Instructor instructor1 = new Instructor("Antonio", 3);
            Instructor instructor2 = new Instructor("Agustin", 2);

            Clase clase1 = new Clase(instructor1, 2, 2000, "Clase1");
            Clase clase2 = new Clase(instructor2, 3, 1500, "Clase2");

            Gym gym = new Gym("La Esquina");

            clase1.AgregarMiembro(miembro1);
            clase1.AgregarMiembro(miembro2);
            

            clase2.AgregarMiembro(miembro1);
            clase2.AgregarMiembro(miembro2);
            clase2.AgregarMiembro(miembro3);
        }
    }
}
