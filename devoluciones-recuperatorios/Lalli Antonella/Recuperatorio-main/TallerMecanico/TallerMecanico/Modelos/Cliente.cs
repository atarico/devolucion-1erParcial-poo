namespace TallerMecanico.Modelos
{
    public class Cliente
    {
        public string NombreCliente { get;  set; }
        public int NumeroCliente { get; private set; }
        public List<Vehiculo> Vehiculos { get; private set; } = new List<Vehiculo>();

        public Cliente( string nombre, int numeroCliente, List<Vehiculo>vehiculos)
        {
            NombreCliente = nombre;
            NumeroCliente = numeroCliente;
            Vehiculos = vehiculos;
        }
      
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

        public void MostrarVehiculos()
        {
            Console.WriteLine($"---Vehiculos del cliente {NombreCliente}---");
            foreach (Vehiculo v in Vehiculos)
            {
                Console.WriteLine($"MARCA DEL VEHICULO: {v.Marca}\nMODELO: {v.Modelo}\nAÑO: {v.Año}\nPATENTE: {v.Patente}");
                Console.WriteLine("---Trabajos realizados---");
                foreach (ServicioDeTrabajo serv in v.serviciosRealizados)
                {
                    Console.WriteLine($"-{serv}  /  ${serv.CostoFijo}");
                }
            }          
        }
    }
}
