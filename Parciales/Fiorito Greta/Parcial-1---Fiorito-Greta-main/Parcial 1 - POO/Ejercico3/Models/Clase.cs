
namespace Ejercico3.Models
{
    public class Clase
    {
        public string Nombre { get; private set; }
        public int Cupo { get; private set; }
        public Instructor Instructor { get; private set; }
        public double Costo { get; private set; }

        public Clase(string nombre, int cupo, Instructor instructor, double costo)
        {
            Nombre = nombre;
            Cupo = cupo;
            Instructor = instructor;
            Costo = costo;
        }
        public int ActualizarCupo(int cupo) 
        {
            if (cupo <= 0)
            {
                Console.WriteLine($"No hay disponibilidad en esta clase :( ");
            }
            else 
            {
                cupo = cupo - 1;
                Console.WriteLine($"Cupo actualizado!! Lugares restantes en {Nombre}: {cupo}");
            }
            return cupo;
        }
        public void MostrarDetallesClase() 
        {
            Console.WriteLine($"---------------------------------------");
            Console.WriteLine($"Nombre de la clase: {Nombre}");
            Console.WriteLine($"Cupo actual: {Cupo}");
            Console.WriteLine($"Instructor a cargo {Instructor.Nombre}");
            Console.WriteLine($"Costo de la clase: ${Costo}");
            Console.WriteLine($"---------------------------------------");
        }
    }
}
