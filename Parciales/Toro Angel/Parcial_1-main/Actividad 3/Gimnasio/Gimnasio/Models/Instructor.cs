namespace Gimnasio.Models
{
    public class Instructor
    {
        public string Nombre { get; private set; }
        public int ExperienciaAños { get; private set; }  

        public Instructor(string nombre, int experienciaAños)
        {
            Nombre = nombre;
            ExperienciaAños = experienciaAños;
        }
    }
}
