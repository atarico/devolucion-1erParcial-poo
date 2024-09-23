namespace Gimnasio.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int NumeroMiembro { get; set; }
        public List<Clase> Clases { get; set; }

        public Cliente(string nombre, int numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
            Clases = new List<Clase>();
        }

        public void InscripcionClase(Clase clase)
        {
            Clases.Add(clase);
            clase.Lugares = clase.Lugares - 1;
            Console.WriteLine($"{Nombre} te anotaste en la clase: {clase.NombreClase} y quedan {clase.Lugares} lugares");
        }
    }
}
