using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2_Albitre.Models
{
    public class ArregloFloral
    {
        public List<Flor> _flores { get; private set; } = new List<Flor>();
        public ArregloFloral()
        {
        }   
        public void AgregarFlor(Flor flor)
        {
            _flores.Add(flor);
        }
        public void QuitarFlor(Flor flor)
        {
            _flores.Remove(flor);
        }
        public double ObtenerCosto()
        {
            double costoTotal = 0;
            foreach (Flor flor in _flores)
            {
                costoTotal += flor.Costo;
            }
            return costoTotal;
        }

        public void MostrarDetallesArreglo()
        {
            Console.WriteLine("Arreglo: \n");
            foreach (Flor flor in _flores)
            {
                flor.MostrarDetallesFlor();
            }
            
        }
    }
}
