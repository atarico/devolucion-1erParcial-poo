namespace Floreria.Modulos
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
     public void MostrarDetallesPedido()
        {
            Console.WriteLine($"Cliente {Nombre}\n{Pedido}");
        }   
    }
}
