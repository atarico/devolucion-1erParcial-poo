
namespace Gimnacio.Modelos
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public double NumeroMiembro { get; private set; }

        public Miembro (string nombre, double numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
        }
       
    }
}
