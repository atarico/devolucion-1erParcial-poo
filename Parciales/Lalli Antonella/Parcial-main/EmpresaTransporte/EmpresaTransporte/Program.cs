using EmpresaTransporte.Modelos;

class Programm
{
    static void Main()
    {
        Conductor conductor1 = new Conductor("Juan Perez", 1248336, new DateTime(2000, 02, 8));
        Vehiculo UnVehiculo = new Autobus("AXF876", 2024, 50, new DateTime(2024, 09, 11), 16, conductor1);
        Vehiculo OtroVehiculo = new Camion("AEH676", 2024, 45, new DateTime(2024, 09, 11), 45);
        UnVehiculo.MostrarDetalles();
        OtroVehiculo.MostrarDetalles();


    }
}
