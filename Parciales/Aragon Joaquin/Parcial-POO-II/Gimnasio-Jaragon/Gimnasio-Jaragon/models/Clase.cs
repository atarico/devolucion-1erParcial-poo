
namespace Gimnasio_Jaragon.models
{
    public class Clase
    {
        public string Nombre { get; private set; }
        public Instructor Instructor { get; private set; }
        public double Costo { get; private set; }
        public int LugaresDisponibles { get; private set; }

        public Clase(string nombre, Instructor instructor, double costo, int lugaresDisponibles)
        {
            Nombre = nombre;
            Instructor = instructor;
            Costo = costo;
            LugaresDisponibles = lugaresDisponibles;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Informacion de la clase: ");
            Console.WriteLine($"------------------------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Instructor: {this.Instructor.Nombre} ");
            Console.WriteLine($"Costo: {this.Costo} ");
            Console.WriteLine($"Lugares disponibles: {this.LugaresDisponibles} \n");
        }

        public void AñadirLugar() => LugaresDisponibles += 1;
        public void QuitarLugar() => LugaresDisponibles -= 1;
    }
}
