using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    internal class Vehiculo
    {
        public string Marca { get { return Marca; } private set { value = Marca; } }
        public string Modelo { get { return Modelo; } private set { value = Modelo; } }
        public int AñoVehiculo {get { return AñoVehiculo; } private set { if (value < 3000) {AñoVehiculo = value; }  } }
        public Dictionary<TrabajoReparacion, double> TrabajosRealizados = new Dictionary<TrabajoReparacion, double>();

       public Vehiculo(string marca, string modelo, int añoVehiculo)
        {
            Marca = marca;
            Modelo = modelo;
            AñoVehiculo = añoVehiculo;
        }

        public void AñadirTrabajoRealizado(TrabajoReparacion trabajote, double costo)
        {
            TrabajosRealizados.Add(trabajote, costo);
            Console.WriteLine($"Trabajo añadido con éxito.");
        }
       

        public void MostrarTrabajosRealizados()
        {
            Console.WriteLine($"\n");
            foreach(var item in TrabajosRealizados)
            {
                Console.WriteLine($"El trabajo constó de {item.Key.DescripcionTrabajo}, tuvó un costo de {item.Key.CostoTrabajo}, y su tipo de trabajo fue {item.Key.TipoTrabajo}. \n");
            }

        }
    }
}
