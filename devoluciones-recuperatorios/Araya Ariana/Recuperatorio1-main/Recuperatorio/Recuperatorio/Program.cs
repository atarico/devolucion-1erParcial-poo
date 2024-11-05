using Recuperatorio.Enum;
using Recuperatorio.Metodos;

public class Program
{
    static void Main()
    {
        Vehiculo auto1 = new Vehiculo("Chevrolet", "pipi", 2020);
        Cliente cliente1 = new Cliente("Ana", 1);
        Reparacion repa1 = new Reparacion(Trabajo.Mecanico);
        Reparacion repa2= new Reparacion(Trabajo.Pintura);
    }
}
