namespace Punto2_Albitre.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Flor margarita = new Flor("margarita", 100);
            Flor rosa = new Flor("rosa", 200);
            Flor violeta = new Flor("violeta", 250);
            ArregloFloral arreglo1 = new ArregloFloral();
            arreglo1.AgregarFlor(margarita);
            arreglo1.AgregarFlor(rosa);
            arreglo1.AgregarFlor(margarita);
            arreglo1.ObtenerCosto();
            Pedido pedido = new Pedido();
            pedido.AgregarArreglo(arreglo1);
            Cliente cliente1 = new Cliente("pablo", pedido);
            cliente1.MostrarResumenPedido();
        }
    }
}