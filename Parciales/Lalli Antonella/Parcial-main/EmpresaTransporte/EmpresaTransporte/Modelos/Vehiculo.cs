

namespace EmpresaTransporte.Modelos
{
    abstract class Vehiculo
    {
        public string NumMatricula { get;  set; }
        public int AñoFabricacion { get;  set;}
        public double Kilometraje { get;  set; }
        public DateTime UltimoMantenimiento { get;  set; }
        public Conductor Conductor { get; set; }

        public Vehiculo(string numMatricula, int añoFabricacion, double kilometraje, DateTime ultimoMantenimiento)
        {
            NumMatricula = numMatricula;
            AñoFabricacion = añoFabricacion;
            Kilometraje = kilometraje;
            UltimoMantenimiento = ultimoMantenimiento;
            Conductor = null;
         
        }
        public Vehiculo(string numMatricula, int añoFabricacion, double kilometraje, DateTime ultimoMantenimiento, Conductor conductor)
        {
            NumMatricula = numMatricula;
            AñoFabricacion = añoFabricacion;
            Kilometraje = kilometraje;
            UltimoMantenimiento = ultimoMantenimiento;
            Conductor = conductor;

        }

        public abstract void MostrarDetalles();
    }
}
