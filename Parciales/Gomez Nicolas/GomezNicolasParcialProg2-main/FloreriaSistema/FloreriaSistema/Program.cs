
using  FloreriaSistema.Modelos;


namespace Floreria
{
    class Program
    {
        static void Main()
        {
            Flor flor1 = new Flor("Margarita",2);
            Flor flor2 = new Flor("Margarita", 2);

            Flor flor3 = new Flor("Margarita",2);

            ArregloFloral ArregloFloral = new ArregloFloral();
            ArregloFloral.AgregarFlor(flor1);
            ArregloFloral.AgregarFlor(flor2);
            ArregloFloral.AgregarFlor(flor3);
            Pedido Pedido = new Pedido(ArregloFloral);
            Cliente Cliente = new Cliente("Nicolas", Pedido);
            Cliente.MostrarResumenPedido();



        }
    }
}
