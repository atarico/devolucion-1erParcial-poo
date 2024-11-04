namespace MecanicoElJuan.Models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public List<Vehiculo> vehiculos { get; private set; } = new List<Vehiculo>();
        public int NumeroCliente { 
            get 
            {
                return ++Numero;
            } 
        }
        public static int Numero { get; private set; } = 0;

        public Cliente(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
        public void MostrarVehiculos()
        {
            Console.WriteLine("el cliente tiene: ");
            foreach (var ve in vehiculos)
            {
                Console.WriteLine($"{ve.Marca}");
            }
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"El cliente {Nombre} de numero {NumeroCliente}, tiene una cantidad de {vehiculos.Count} vehiculos.");
        }
    }
}
