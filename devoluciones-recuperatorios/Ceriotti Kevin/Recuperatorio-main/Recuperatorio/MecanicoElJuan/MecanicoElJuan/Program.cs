using MecanicoElJuan.Models;

class Program
{
    static void Main()
    {
        Vehiculo fort = new Vehiculo("RumRum", "Fium", 2025);
        Vehiculo Chevrolet = new Vehiculo ("ailux", "todoTerreno", 2002);
        Cliente cliente = new Cliente("Agustin");
        Cliente cliente1 = new Cliente("Antonio");
        Mecanico mecanico = new Mecanico("Ana", "Mecanica General");
        Trabajo CambioAceite = new Trabajo( 300, "cambio de aceite", mecanico, Chevrolet);

       cliente.AgregarVehiculo(fort);
        cliente.AgregarVehiculo(Chevrolet);

        fort.MostrarDetalles();

        cliente.MostrarVehiculos();

        cliente1.MostrarDetalles();
        cliente.MostrarDetalles();

        CambioAceite.MostrarDetalles();

        
    }
}
