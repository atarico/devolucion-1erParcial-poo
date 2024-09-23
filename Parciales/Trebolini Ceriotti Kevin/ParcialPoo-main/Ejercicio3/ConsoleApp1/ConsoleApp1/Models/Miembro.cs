namespace ConsoleApp1.Models
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public int NumeroMiembro { get; private set; }
        public List<Clase> Clase { get; private set; } = new List<Clase>();

        public Miembro(string nombre, int numeroMiembro, List<Clase> clase)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
            Clase = clase;
        }
        public void InscribirseAClase(Clase clase)
        {
            int TotalClases = 0;
            Clase.Add(clase);
            TotalClases = clase.NumeroLugares - 1;
        }
    }
}
