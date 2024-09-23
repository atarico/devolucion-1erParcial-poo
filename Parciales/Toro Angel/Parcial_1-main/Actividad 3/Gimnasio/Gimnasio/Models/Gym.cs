namespace Gimnasio.Models
{
    public class Gym
    {
        public string Nombre { get; private set; }
        public List<Clase> Clases { get; private set; } = new List<Clase>();

        public Gym(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarClase(Clase clase)
        {
            Clases.Add(clase);
        }
    }
}
