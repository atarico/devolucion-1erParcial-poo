using Floreria.Modulos;

namespace Floreria;
class program
{
    static void Main()
    {  
        Console.WriteLine("Ingrese su nombre Para comenzar: ");
        string nombre = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine($"Hola {nombre} desea realizar un pedido?");
        string resp = Console.ReadLine();
        if (resp == "si") 
        {
            Console.WriteLine("Que desea encargar:\n1-Margarita\n2-Clavel\n3-Tulipan\n4-Estrella Federal\n5-Aloe Vera");
            int encargo=int.Parse(Console.ReadLine());
            switch (encargo)
            {
                case 1:
                    Flor margarita = new Flor("Margarita", 15);
                    break;
                case 2:
                    Flor clavel = new Flor("Clavel", 13);
                    break;
                case 3:
                    Flor tulipan = new Flor("Tulipan", 22);
                    break;
                case 4:
                    Flor estrella = new Flor("Estrella Federal", 17);
                    break;
                case 5:
                    Flor aloe = new Flor("Aloe Vera", 12);
                    break;
            }
            Console.WriteLine("ingrese Cantidad que desea encargar");
            int cant= int.Parse(Console.ReadLine());
        }

        Pedido unPedido = new Pedido();
        Cliente unCliente = new Cliente(nombre,unPedido);

    }
}