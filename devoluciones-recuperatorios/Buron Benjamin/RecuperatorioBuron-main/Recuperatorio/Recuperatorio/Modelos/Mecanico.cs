namespace Recuperatorio.Modelos
{
    public class Mecanico
    {
        public string Nombre {  get;private set; }
        public string Especialidad { get; private set; }

        public Mecanico(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
        }

    }
}
