namespace Floreria.Models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido? Pedido { get; private set; }

        public Cliente(string nombre, Pedido pedido)
        {
            Nombre = nombre;
            Pedido = pedido;
        }

        public void MostrarResumenPedido()
        {
            Console.WriteLine($"Cantidad de arreglos florales: {Pedido.ArreglosFlorales.Count}");
            Console.WriteLine($"Total a pagar: {Pedido.Total}" + ((Pedido.ArreglosFlorales.Count > 5) ? "Se aplico un 10% de descuento" : ""));
        }
    }
}
