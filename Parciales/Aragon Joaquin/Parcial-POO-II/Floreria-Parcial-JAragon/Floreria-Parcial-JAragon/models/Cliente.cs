

namespace Floreria_Parcial_JAragon.models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido Pedido { get; private set; }

        public Cliente(string nombre, Pedido pedido)
        {
            Nombre = nombre;
            Pedido = pedido;
        }

        public void MostrarResumenPedido()
        {
            double PrecioFinal = 0;
            Console.WriteLine($"Hola cliente {this.Nombre}. Preparando tu pedido...");
            Console.WriteLine("----------------------------------------------");
            
            foreach(var pedido in Pedido.ArreglosFlorares)
            {
                PrecioFinal += Pedido.Total;
            }

            Console.WriteLine($"Sera un total de ${PrecioFinal} \n");

        }
    }
}
