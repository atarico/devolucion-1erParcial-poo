
namespace Gimnasio_Jaragon.models
{
    public class Gimnasio
    {
        public string Nombre { get; private set; }
        public List<Clase> Clases { get; private set; } = new List<Clase>();

        public Gimnasio(string nombre)
        {
            Nombre = nombre;
        }

        public void AñadirClase(Clase clase) => Clases.Add(clase);

        public void AñadirClase(List<Clase> clase)
        {
            foreach (var cosa in clase) { Clases.Add(cosa); }
        }


        public void ObtenerInfoClases()
        {
            foreach(var clase in Clases)
            {
                Console.WriteLine($"Clase: {clase.Nombre}, precio {clase.Costo}");
            }
        }
    }
}
