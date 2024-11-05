namespace Floreria.Modelos
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
            Console.WriteLine($"El cliente {Nombre} realizo el siguiente pedido: ");
        }

    }
}
