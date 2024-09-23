namespace ConsoleApp1.Models
{
    public class Instructor
    {
        public string Nombre { get; private set; }
        public int Experiencia { get; private set; }

        public Instructor(string nombre, int experiencia)
        {
            Nombre = nombre;
            Experiencia = experiencia;
        }
    }
}
