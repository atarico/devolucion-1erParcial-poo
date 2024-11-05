namespace Floreria.Modulos
{
    public class Program
    {
        static void Main()
        {
            Flor flor1 = new Flor("Camelia", 10);
            Flor flor2 = new Flor("Orquidea", 15);
            Flor flor3 = new Flor("Rosa", 13);
            Flor flor4 = new Flor("Tulipan", 16);

            List<Flor> flores = new List<Flor>();
            flores.Add(flor1);

            ArregloFloral arreglo1 = new ArregloFloral(flores);
            arreglo1.AgregarFlor(flor2);
            ArregloFloral arreglo2 = new ArregloFloral(flor3);
            arreglo2.AgregarFlor(flor4);

            Pedido pedido = new Pedido(arreglo1);
            pedido.AgregarArreglo(arreglo2);

            Cliente cliente = new Cliente("Juan Perez", pedido);
            cliente.MostrarResumenPedido();
        }
    }
}