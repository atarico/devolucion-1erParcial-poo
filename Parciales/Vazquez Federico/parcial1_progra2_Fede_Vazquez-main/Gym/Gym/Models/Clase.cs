namespace Gym.Models
{
    public class Clase
    {
        public Instructor Instructor { get; private set; }
        public List<Miembro> Miembros { get; private set; } = new List<Miembro>();
        public double Costo { get; private set; }
        public int EspacioDisponible { get; private set; }

        public Clase(Instructor instructor, double costo, int espacioTotal)
        {
            Instructor = instructor;
            Costo = costo;
            EspacioDisponible = espacioTotal;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Instructor: {Instructor}, costo: {Costo}");
            Console.WriteLine($"TotalMiembros: {Miembros.Count}, espacios disponibles: {EspacioDisponible}");
        }

        public void CambiarInstructor(Instructor instructor) => Instructor = instructor;
        public void AgregarMiembro(Miembro miembro)
        {
            Miembros.Add(miembro);
            EspacioDisponible--;
        }
        public void QuitarMiembro(Miembro miembro)
        {
            Miembros.Remove(miembro);
            EspacioDisponible++;
        }
    }
}
