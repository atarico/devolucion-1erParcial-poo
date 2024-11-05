using Floreria.Models;

class Program
{
    static void Main()
    {
        Flor flor1 = new Flor("Rosa", 3000);
        Flor flor2 = new Flor("Lirio", 2500);
        Flor flor3 = new Flor("Tulipan", 1000);

        ArregloFloral arreglo1 = new ArregloFloral(flor3);
        arreglo1.AgregarFlor(flor3);
        arreglo1.AgregarFlor(flor3);

        ArregloFloral arreglo2 = new ArregloFloral(flor1);
        ArregloFloral arreglo3 = new ArregloFloral(flor1);
        ArregloFloral arreglo4 = new ArregloFloral(flor1);
        ArregloFloral arreglo5 = new ArregloFloral(flor1);

        Pedido pedido = new Pedido(arreglo1);

        Cliente cliente1 = new Cliente("Pepito", pedido);
        cliente1.MostrarResumenPedido();
    }
}