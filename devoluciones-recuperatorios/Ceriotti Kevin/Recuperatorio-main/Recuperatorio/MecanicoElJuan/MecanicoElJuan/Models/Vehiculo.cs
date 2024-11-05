namespace MecanicoElJuan.Models
{
    public class Vehiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int AñoVehiculo { get; private set; }

        public Vehiculo(string marca, string modelo, int añoVehiculo) 
        {
            Marca = marca;
            Modelo = modelo;
            AñoVehiculo = añoVehiculo;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Vehiculo de la marca: {Marca}, Modelo {Modelo}, del año: {AñoVehiculo}");
        }
    }
}
