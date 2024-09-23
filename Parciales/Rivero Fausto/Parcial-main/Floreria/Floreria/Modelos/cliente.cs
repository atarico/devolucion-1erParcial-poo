

namespace Floreria.Modelos
{
    public class cliente
    {
        public string Nombre {  get; private set; } 
        public Pedido pedido { get; private set; } = new Pedido();

        public cliente(string nombre,Pedido pedido)
        {
            pedido = new Pedido();
            Nombre = nombre;
        }
        public void MostrarResumenPedido()
        {
            Console.WriteLine($"{}");
        }
    }
}
