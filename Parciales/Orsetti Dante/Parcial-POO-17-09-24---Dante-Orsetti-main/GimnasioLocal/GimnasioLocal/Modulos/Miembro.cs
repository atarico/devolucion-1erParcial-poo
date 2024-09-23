namespace GimnasioLocal.Modulos
{
    public class Miembro
    {
        private string _nombre;
        private int _numero;
        private List<Clase> _clases = new List<Clase>();

        public string Nombre => _nombre;
        public int Numero => _numero;
        public List<Clase> Clases => _clases;

        public Miembro(string nombre, int numero)
        {
            _nombre = nombre;
            _numero = numero;
        }

        public void InscribirseEnClase(Clase clase)
        {
            _clases.Add(clase);
            clase.AgregarMiembro(this);
        }

        public void SalirDeClase(Clase clase)
        {
            _clases.Remove(clase);
            clase.QuitarMiembro(this);
        }
    }
}
