
namespace Ejercicio2.Models
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
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"Cliente: {Nombre}");
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"Detalle del pedido:   ");
            if (Pedido.DescuentoAplicado == true)
            {
                Console.WriteLine($"El Cliente clasificó para el descuento");
                Console.WriteLine($"Total con el descuento: {Pedido.Total}");
            }
            else 
            {
                Console.WriteLine($"El cliente NO clasificó para el descuento");
                Console.WriteLine($"Total SIN descuento: {Pedido.Total}");
            }
            Console.WriteLine($"-----------------------------------------------");
            
        }
    }
}
