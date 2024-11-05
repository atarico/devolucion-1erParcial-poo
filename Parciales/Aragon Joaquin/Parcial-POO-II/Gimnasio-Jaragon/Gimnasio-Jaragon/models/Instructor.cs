

namespace Gimnasio_Jaragon.models
{
    public class Instructor
    {
        public string Nombre { get; private set; }
        public int AnioExperiencia { get; private set; }

        public Instructor(string nombre, int anioExperiencia)
        {
            Nombre = nombre;
            AnioExperiencia = anioExperiencia;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Su nombre es: {this.Nombre}");
            Console.WriteLine($"Sus años de experiencia son {this.AnioExperiencia} \n");
        }
    }
}
