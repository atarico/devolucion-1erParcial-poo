namespace Recuperatorio.Metodos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public int NumCliente { get;private set; }
        public Vehiculo Vehiculo { get; private set; }
        
        public Cliente(string nombre, int numCliente,Vehiculo vehiculo)
        {  
            Nombre = nombre; 
            NumCliente = numCliente;
            Vehiculo = vehiculo;
        }
        public void MostrarDetalle()
        {
            Console.WriteLine($"El cliente numero {NumCliente}, se llama{Nombre}, y tiene {Vehiculo}");
        }
        public void RegistrarCliente()
        {

        }
    
    }
}
