using Recuperatorio.Enum;
using Recuperatorio.Modelos;

class Program
{
    static void Main()
    {   Cliente Benjamin = new Cliente("benjamin",159357);
        Vehiculo auto = new Vehiculo("Chevrolet", "Corsa", 2015,Benjamin);
        Vehiculo camioneta = new Vehiculo("Chevrolet", "astra", 2009,Benjamin);
        Cliente Jose = new Cliente("jose",7963);
        Vehiculo auto2 = new Vehiculo("Fiat", "Duna", 1993, Jose);
        Mecanico electricista = new Mecanico("Alberto", "electricista");
        Mecanico pintor = new Mecanico("Roberto", "pintor");
        Mecanico general = new Mecanico("Ruperto","Mecanica en General");
        TrabajoReparacion trabajito = new TrabajoReparacion(pintor, TipoTrabajo.Pintura, 15000);
        List<Vehiculo>vehiculos = new List<Vehiculo>();
        vehiculos.Add(auto);
        vehiculos.Add(camioneta);

        trabajito.MostrarDetallesReparacion();
        Benjamin.MostrarDetallesCliente();
        auto.MostrarDetallesVehiculo();

    }
}
