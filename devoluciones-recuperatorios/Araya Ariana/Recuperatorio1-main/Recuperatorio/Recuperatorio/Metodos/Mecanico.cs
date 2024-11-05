namespace Recuperatorio.Metodos
{
    public class Mecanico
    {
        public string Nombre { get; private set; }
        public List<Mecanico> Mecanicos { get; private set; } = new List<Mecanico>();

        public Mecanico(string nombre, Mecanico mecanico) {
           
            Nombre = nombre;
            Mecanicos.Add(mecanico);
        }

        public void AgregarMecanico(Mecanico mecanico) 
        {
            Mecanicos.Add(Mecanico);
        }
    }
}
