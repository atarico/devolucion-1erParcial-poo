using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Floreria.Modelos
{
    public class Arreglofloral
    {
        private List<Flor> _flores;

        public Arreglofloral()
        {
            _flores = new List<Flor>();
        }

        public void AgregarFlor(Flor flor)
        {
            _flores.Add(flor);
            _flores.Add(flor);
            _flores.Add(flor);
            _flores.Add(flor);
            _flores.Add(flor);

        }

        public double ObtenerCostoArreglo()
        {
            double Total = 0;
            
            foreach (var Flor in _flores)
            {
               
                Total = Flor.Costo;
            }
            return Total;

          
        }
    }
}
