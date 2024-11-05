namespace Floreria.Models
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
            Console.WriteLine("Resumen del pedido");
            Console.WriteLine("------------------");

            //Console.WriteLine($"Pedido:");
            //foreach (var item in Pedido.ArregloFlores)
            //{
            //    Console.WriteLine($"Arreglo floral: {Pedido.ArregloFlores}");   (No supe mostrar el pedido con las flores)
            //}

            Console.WriteLine($"Costo total: {Pedido.Total:C}");
            if (Pedido.DescuentoAplicado() == false)
            {
                Console.WriteLine("Sin Descuento");
            }
            else { Console.WriteLine("Con Descuento"); }

        }
    }
}
