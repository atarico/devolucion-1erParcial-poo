namespace Floreria.Modulos
{
    public class Cliente
    {
        private string _nombre;
        private Pedido _pedido;
        public string Nombre => _nombre;
        public Pedido Pedido => _pedido;

        public Cliente(string nombre, Pedido pedido)
        {
            _nombre = nombre;
            _pedido = pedido;
        }
        
        public void MostrarResumenPedido()
        {
            Console.WriteLine("________________________");
            Console.WriteLine("Detalles del pedido:");
            Console.WriteLine($"Cliente: {Nombre}");
            Console.WriteLine($"Cantidad de arreglos: {Pedido.ArreglosFlorales.Count()}");
            int contador = 0;
            foreach(var arreglo in Pedido.ArreglosFlorales)
            {
                Console.WriteLine($"\nFlores del arreglo {++contador}:");
                foreach(var flor in arreglo.Flores)
                {
                    Console.WriteLine(flor.Tipo);
                }
            }
            Console.WriteLine($"\nTotal: {Pedido.Total:C}");
            Console.WriteLine($"Descuento Aplicado: {(Pedido.DescuentoAplicado ? "Si" : "No")}");
            Console.WriteLine("________________________");
        }
    }
}
