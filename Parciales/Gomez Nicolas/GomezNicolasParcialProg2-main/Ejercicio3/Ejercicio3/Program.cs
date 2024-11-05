


using Ejercicio3.Modulos;
namespace Gimnasio
{
    class Program
    {
        static void Main()
        {
            Instructor Instructor = new Instructor("Martin", 3);
            Miembro Miembro1 = new Miembro("Nicolas", 123);
            Miembro Miembro2 = new Miembro("Pepe", 123);

            Miembro Miembro3 = new Miembro("Marcelo", 123);
            List<Miembro> MiembroList = new List<Miembro>();
            MiembroList.Add(Miembro1);
            MiembroList.Add(Miembro2);
            MiembroList.Add(Miembro3);
            Miembro Miembro4 = new Miembro("Marce", 123);
            Miembro Miembro5 = new Miembro("Ma", 123);



            Clase Clase = new Clase("Cross fit", 100, 4, Instructor);
            Clase.AgregarMiembro(MiembroList);





            Clase.MostrarDetalles();


        }
    }
}

