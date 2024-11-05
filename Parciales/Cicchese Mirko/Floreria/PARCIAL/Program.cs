using PARCIAL.Models;

public class Program
{
    static void Main()
    {
        Flor flor1 = new Flor("Rosa", 100);
        Flor flor2 = new Flor("Girasol", 50);
        Flor flor3 = new Flor("Tulipan", 200);
        Flor flor4 = new Flor("Jazmin", 80);


        ArregloFloral arreglo1 = new ArregloFloral();
        arreglo1.AgregarFlor(flor1);
        arreglo1.AgregarFlor(flor3);

        ArregloFloral arreglo2 = new ArregloFloral();
        arreglo2.AgregarFlor(flor1);
        arreglo2.AgregarFlor(flor2);
        arreglo2.AgregarFlor(flor3);


        ArregloFloral arreglo3 = new ArregloFloral();
        arreglo3.AgregarFlor(flor1);
        arreglo3.AgregarFlor(flor2);
        arreglo3.AgregarFlor(flor4);



        Pedido pedido1 = new Pedido(arreglo3);

        Pedido pedido2 = new Pedido(arreglo2);

        Cliente cliente1 = new Cliente("Juan Perez", pedido1);

        cliente1.MostrarResumenPedido();

        Cliente cliente2 = new Cliente("Pedro Martinez", pedido2);

        cliente2.MostrarResumenPedido();
    }
}