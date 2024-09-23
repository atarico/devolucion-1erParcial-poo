namespace Floreria.Modelos {
    class Programm
    {
        static void Main()
        {
            // flores 
            Flor Rosa = new Flor("Rosa", 100);
            Flor Tulipan = new Flor("Tulipan", 200);
            Flor Girasol = new Flor("Girasol", 300);
            Flor Margarita = new Flor("Margarita", 400);
            ArregloFloral Arreglo1 = new ArregloFloral(new List<Flor> { Rosa, Tulipan});

            Pedido Pedido1 = new Pedido( new List<ArregloFloral> { Arreglo1 }, descuento: true);
            Cliente cliente1 = new Cliente("Antonella Lalli", Pedido1);
            cliente1.MostrarResumenPedido();
  
            Console.WriteLine ($"El costo final es: ${Pedido1.ObtenerTotal(new List<ArregloFloral> { Arreglo1 })}");



        }
    }
}