using System.Reflection;
using System.Text.RegularExpressions;

namespace Recuperatorio.Modelos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public int NroCliente { get; private set; }
        public List<Vehiculo> Vehiculos { get; private set; }= new List<Vehiculo>();

        public Cliente(string nombre, int nroCliente)
        {
            Nombre = nombre;
            NroCliente = nroCliente;
                       
        } 

        public void MostrarDetallesCliente()
        {
            foreach(var vehiculo in Vehiculos)
            {
                Console.WriteLine(Vehiculos);
            }
        }
        

    }
}
