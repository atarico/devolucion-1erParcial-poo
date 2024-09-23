using Floreria.Modelos;

class Program
{
    static void Main()
    {
        Flor flor = new Flor("awsas",100);
        Flor flor1 = new Flor("awsas",150);
        Flor flor2 = new Flor("awsas",20);
        Flor flor3 = new Flor("awsas",100);
        Flor flor4 = new Flor("awsas",400);
        Arreglofloral arreglofloral = new Arreglofloral();
        arreglofloral.AgregarFlor(flor);
        Pedido pedido = new Pedido();
    }
}
