namespace Recuperatorio.Modelos
{
    public class Vehiculo
    {
        public string Marca { get;private set; }
        public string Modelo {  get;private set; }
        public int Año { get;private set; } 
        public Cliente Cliente { get;private set; } 

        public List<TrabajoReparacion> Trabajo {  get; private set; } = new List<TrabajoReparacion>();

        public Vehiculo(string marca, string modelo, int año,Cliente cliente)
        {
            Marca = marca;
            Modelo = modelo;
            Año= año;
            Cliente = cliente;
        }

        public void MostrarDetallesVehiculo()
        {
        Console.WriteLine($"Vehiculo: {Marca}\nModelo: {Modelo}\nFecha de Fabricacion: {Año}");
            
        }


    }
}
