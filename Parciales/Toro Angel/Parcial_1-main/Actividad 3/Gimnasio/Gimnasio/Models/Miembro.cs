namespace Gimnasio.Models
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public int NumeroDeMiembro { get; private set; }

        public Miembro(string nombre, int numeroDeMiembro)
        {
            Nombre = nombre;
            NumeroDeMiembro = numeroDeMiembro;
        }
    }
}
