namespace MecanicoElJuan.Models
{
    public class Trabajo
    {
        public Mecanico Mecanico { get; private set; }
        public Vehiculo Vehiculo { get; private set;}
        public double CostoFijo { get; private set; }
        public string TipoReparacion { get; private set; }
          
        public double CostoTotal
        {
            get
            {
                double Total = 0;
                Total += CostoFijo;

                if (TipoReparacion == "cambio de aceite") { return Total += 100; }
                else if (TipoReparacion == "reparacion electrica") { return Total += 200; }
                else if (TipoReparacion == "ajustes de motor") { return Total += 300; }
                else return Total;
            }
        }


        public Trabajo( double costoFijo, string tipoReparacion, Mecanico mecanico, Vehiculo vehiculo) 
        {
            CostoFijo = costoFijo;
            TipoReparacion = tipoReparacion;
            Mecanico = mecanico;
            Vehiculo = vehiculo;
        }

        public void RealizarReparacion()
        {
            Console.WriteLine($"se va a realizar una reparacion al vehiculo: {Vehiculo.Marca} de tipo: {TipoReparacion} con un costo de: {CostoTotal}");
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Se a realizado un trabajo de {TipoReparacion}, por el mecanico {Mecanico.Nombre} al vehiculo {Vehiculo.Marca}, con un valor de: {CostoTotal}");
        }
    }
}
