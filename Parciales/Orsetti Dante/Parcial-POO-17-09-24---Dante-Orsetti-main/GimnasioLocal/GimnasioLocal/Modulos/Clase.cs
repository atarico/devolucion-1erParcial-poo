namespace GimnasioLocal.Modulos
{
    public class Clase
    {
        private string _nombre;
        private Instructor? _instructor;
        private int _lugaresDisponibles;
        private double _costo;
        private List<Miembro> _miembros = new List<Miembro>();

        public string Nombre => _nombre;
        public Instructor? Instructor => _instructor;
        public int LugaresDisponibles => _lugaresDisponibles;
        public double Costo => _costo;
        public List<Miembro> Miembros => _miembros;

        public Clase(string nombre, int lugaresDisponibles, double costo)
        {
            _nombre = nombre;
            _lugaresDisponibles = lugaresDisponibles;
            _costo = costo;
        }

        public void AsignarInstructor(Instructor instructor)
        {
            _instructor = instructor;
        }

        public void AgregarMiembro(Miembro miembro)
        {
            _miembros.Add(miembro);
            --_lugaresDisponibles;
        }

        public void QuitarMiembro(Miembro miembro)
        {
            _miembros.Remove(miembro);
            ++_lugaresDisponibles;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine("Detalles de la clase:\n");
            Console.WriteLine($"Nombre de la clase: {Nombre}");
            Console.WriteLine($"Instructor: {Instructor.Nombre}, Experiencia: {Instructor.Experiencia} años");
            Console.WriteLine($"Lugares Disponibles: {LugaresDisponibles}");
            Console.WriteLine($"Costo: {Costo:C}\n");
            Console.WriteLine($"Miembros: ");
            foreach(var miembro in _miembros)
            {
                Console.WriteLine($"Numero: {miembro.Numero}, Nombre: {miembro.Nombre}");
            }
            Console.WriteLine("___________________________________________");
        }
    }
}
