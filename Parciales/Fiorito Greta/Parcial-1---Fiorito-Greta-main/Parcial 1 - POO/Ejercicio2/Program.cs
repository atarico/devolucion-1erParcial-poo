
namespace Ejercicio2.Models;

class Program 
{
    static void Main() 
    {
        /*AGREGAR FLORES*/
        Flor flor1 = new Flor("Rosa",10);
        Flor flor2 = new Flor("Jasmín", 2);
        Flor flor3 = new Flor("Violetas", 6);

        /*AGREGAR ARREGLO*/
        ArregloFloral arreglo1 = new ArregloFloral(flor1);
        arreglo1.AgregarFlor(flor2);
        arreglo1.AgregarFlor(flor1);

        /*AGREGAR PEDIDO*/
        Pedido pedido1 = new Pedido(arreglo1);
        /*INGRESAR CLIENTE */
        Cliente cliente1 = new Cliente("Paola",pedido1 );

        /*MOSTRAR RESUMEN DEL PEDIDO*/
        cliente1.MostrarResumenPedido();


        

    }
}