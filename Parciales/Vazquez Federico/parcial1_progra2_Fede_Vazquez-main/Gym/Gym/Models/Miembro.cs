namespace Gym.Models
{
    public class Miembro
    {
        static int _nroMiembro;
        public string Nombre { get; private set; }
        public int NroMiembro { get; private set; }

        public Miembro(string nombre)
        {
            Nombre = nombre;

            _nroMiembro++;
            NroMiembro = _nroMiembro;
        }
    }
}
