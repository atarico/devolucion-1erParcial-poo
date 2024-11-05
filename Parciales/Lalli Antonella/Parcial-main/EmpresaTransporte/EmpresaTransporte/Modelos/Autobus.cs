
namespace EmpresaTransporte.Modelos
{
     class Autobus : Vehiculo

    {
        public int CantidadDeAsientos { get; private set;}
        public Autobus(string numMatricula, int añoFabricacion, double kilometraje, DateTime ultimoMantenimiento, int cantidadDeAsientos ) : base(numMatricula, añoFabricacion, kilometraje, ultimoMantenimiento)
        {
            CantidadDeAsientos = cantidadDeAsientos;

        }
        public Autobus(string numMatricula, int añoFabricacion, double kilometraje, DateTime ultimoMantenimiento, int cantidadDeAsientos, Conductor conductor) : base(numMatricula, añoFabricacion, kilometraje, ultimoMantenimiento, conductor)
        {
            CantidadDeAsientos = cantidadDeAsientos;

        }
        // public void ConsultarConductor()
        // {
        //     Console.WriteLine($"El vehiculo esta asignado para {Conductor.Nombre}");
        //  }
        public override void MostrarDetalles()
        {
            Console.WriteLine($"El vehiculo {NumMatricula}, fabricado en {AñoFabricacion} cuenta con {Kilometraje}KM.\nUltimo Mantenimiento:{UltimoMantenimiento}.\nCantidad de asientos: {CantidadDeAsientos}");
            if (Conductor != null)
            {
                Console.WriteLine($"Esta vehiculo esta asignado para {Conductor.Nombre}");
            }
        }

    }
}
