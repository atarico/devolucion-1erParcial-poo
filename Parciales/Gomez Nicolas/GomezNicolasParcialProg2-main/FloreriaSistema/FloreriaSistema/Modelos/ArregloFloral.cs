using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloreriaSistema.Modelos

{
    public class ArregloFloral
    {
        public List<Flor> Flores {get; private set; } = new List<Flor>();


        public ArregloFloral() { Flores = new List<Flor>(); }

        public ArregloFloral(Flor flor) { 
            Flores.Add(flor); 
        }
        public ArregloFloral(List<Flor> flores)
        {
            Flores = flores;
        }
        public double ObtenerCostoArreglo()
        {
            double total = 0;
            foreach (Flor flor in Flores)
            {
                total = total + flor.Costo;
            }
            return total;
        }
        public void  AgregarFlor(Flor flor)
        {
            Flores.Add(flor);
        }
        public void  MostrarDetalles()
        {
            Console.WriteLine($"Cantidad de flores {Flores.Count}");
            foreach(Flor flor in Flores)
            {
                flor.MostrarDetalles();
            }
            Console.WriteLine($"Costo Total {ObtenerCostoArreglo}");
        }
        
    }
}
