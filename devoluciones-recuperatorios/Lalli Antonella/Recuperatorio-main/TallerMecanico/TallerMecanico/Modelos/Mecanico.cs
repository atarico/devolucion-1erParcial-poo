
namespace TallerMecanico.Modelos
{
    public class Mecanico
    {
        public string NombreMecanico { get; private set; }
        public string Especialidad { get; private set; }

        public Mecanico(string nombre, string especialidad)
        {
            NombreMecanico = nombre;
            Especialidad = especialidad;
        }
    }
}
