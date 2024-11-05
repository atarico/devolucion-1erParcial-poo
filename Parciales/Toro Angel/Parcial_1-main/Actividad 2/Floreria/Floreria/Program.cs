using Floreria.Models;

namespace Floreria
{
    public class Program
    {
        static void Main()
        {
            Flor flor1 = new Flor("Rosa", 5);
            ArregloFloral arregloFloral1 = new ArregloFloral();
            ArregloFloral arregloFloral2 = new ArregloFloral();
            ArregloFloral arregloFloral3 = new ArregloFloral();
            ArregloFloral arregloFloral4 = new ArregloFloral();
            ArregloFloral arregloFloral5 = new ArregloFloral();
            ArregloFloral arregloFloral6 = new ArregloFloral();

            arregloFloral1.AgregarFlores(flor1);
            arregloFloral2.AgregarFlores(flor1);
            arregloFloral3.AgregarFlores(flor1);
            arregloFloral4.AgregarFlores(flor1);
            arregloFloral5.AgregarFlores(flor1);
            arregloFloral6.AgregarFlores(flor1);

            Pedido pedido = new Pedido();

            pedido.AgregarArregloFloral(arregloFloral1);
            pedido.AgregarArregloFloral(arregloFloral2);
            pedido.AgregarArregloFloral(arregloFloral3);
            pedido.AgregarArregloFloral(arregloFloral4);
            pedido.AgregarArregloFloral(arregloFloral5);
            pedido.AgregarArregloFloral(arregloFloral6);

            Cliente cliente = new Cliente("Nicolas", pedido);

            cliente.MostrarResumenPedido();
        }
    }
}
