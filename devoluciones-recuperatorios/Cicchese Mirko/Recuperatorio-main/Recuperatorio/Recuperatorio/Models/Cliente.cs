namespace Recuperatorio.Models
{
    public class Cliente
    {
        public int Codigo { get; private set; }
        public List<Vehiculos> VehiculoCliente { get; private set; } = new List<Vehiculos>();

        public Cliente(int codigo)
        {
            Codigo = codigo;
        }

        public void AñadirVehiculo(Vehiculos vehiculo)
        {
            VehiculoCliente.Add(vehiculo);
        }

        public void Detalles()
        {
            Console.WriteLine("\n");
            foreach (var vehiculos in VehiculoCliente)
            {
                Console.WriteLine($"Cliente {Codigo}... Tu vehiculo: {vehiculos.Modelo} tiene un total de reparacion de: ${vehiculos.TotalArreglos}");
            }
        }
    }
}
