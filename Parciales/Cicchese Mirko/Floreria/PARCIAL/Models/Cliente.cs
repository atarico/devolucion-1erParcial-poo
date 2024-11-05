namespace PARCIAL.Models
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
            Console.WriteLine($"El cliente {Nombre} tiene un pedido con un total de: ${Pedido.Total}");

            if (Pedido.DescuentoAplicado)
            {
                Console.WriteLine($"Con un descuento de: {Pedido.Total * 0.9}");
            }

        }
    }

}
