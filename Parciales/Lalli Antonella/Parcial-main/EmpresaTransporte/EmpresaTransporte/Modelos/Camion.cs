
namespace EmpresaTransporte.Modelos
{
     class Camion : Vehiculo
    { 
        public double CapacidadDeCarga { get; private set; }

        public Camion(string numMatricula, int añoFabricacion, double kilometraje, DateTime ultimoMantenimiento, double capacidadDeCarga) : base(numMatricula,añoFabricacion, kilometraje, ultimoMantenimiento)
        {
            CapacidadDeCarga = capacidadDeCarga;
        }
        public override void MostrarDetalles()
        {
            Console.WriteLine($"El vehiculo {NumMatricula}, fabricado en {AñoFabricacion} cuenta con {Kilometraje}KM.\nUltimo Mantenimiento:{UltimoMantenimiento}\nCapacidad de carga: {CapacidadDeCarga}.");
        }
    }
}
