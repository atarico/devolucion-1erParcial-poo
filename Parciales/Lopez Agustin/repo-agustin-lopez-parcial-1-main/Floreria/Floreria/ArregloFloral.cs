using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floreria
{
     class ArregloFloral
    {
        List<Flor> Florerio = new List<Flor>();

        public ArregloFloral(Flor flor)
        {
         Florerio.Add(flor);
        }

        public double ObtenerCostoArreglo()
        {
            double florsum = 0;
            foreach(Flor flor in Florerio)
            {
                 florsum =+ flor.Costo;
            }

            return florsum;

        }
    }
}
