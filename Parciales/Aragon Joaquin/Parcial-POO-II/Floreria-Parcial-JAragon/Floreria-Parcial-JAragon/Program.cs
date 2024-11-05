using Floreria_Parcial_JAragon.models;

public class Program
{
    static void Main()
    {
        Flor Margarita = new("Margarita",40);
        Flor Rosa = new("Rosa", 25);
        Flor Azular = new("Azular", 30);
        Flor Dorado = new("Flor Dorada", 333);

        ArregloFloral Arreglo1 = new();
        ArregloFloral Arreglo2 = new();
        ArregloFloral Arreglo3 = new();
        ArregloFloral Arreglo4 = new();
        ArregloFloral Arreglo5 = new();

        //hice la sobrecarga pero me olvide de como pasarla como parametro
        Arreglo1.AñadirFlor(Margarita);
        Arreglo1.AñadirFlor(Margarita);
        Arreglo1.AñadirFlor(Margarita);
        Arreglo1.AñadirFlor(Azular);
        Arreglo1.AñadirFlor(Rosa);

        Arreglo2.AñadirFlor(Rosa);
        Arreglo3.AñadirFlor(Azular);
        Arreglo4.AñadirFlor(Margarita);
        Arreglo5.AñadirFlor(Dorado);

        Pedido pedido1 = new();
        Pedido pedido2 = new();

        pedido1.AñadirArregloFloral(Arreglo1);
        //hice la sobrecarga pero de nuevo, no se como añadirlo como argumento.
        pedido2.AñadirArregloFloral(Arreglo1);
        pedido2.AñadirArregloFloral(Arreglo2);
        pedido2.AñadirArregloFloral(Arreglo3);
        pedido2.AñadirArregloFloral(Arreglo4);
        pedido2.AñadirArregloFloral(Arreglo5);

        Console.WriteLine($"Total estimado del pedido1: ${pedido1.Total} \n");
        Console.WriteLine($" {pedido1.DescuentoAplicado}");

        Cliente Pedrito = new("Pedrito", pedido1);
        Pedrito.MostrarResumenPedido();

        Cliente Maria = new("Maria", pedido2);
        Maria.MostrarResumenPedido();
    }
}