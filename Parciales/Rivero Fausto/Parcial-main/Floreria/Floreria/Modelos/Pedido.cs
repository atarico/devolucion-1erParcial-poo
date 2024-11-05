

using System.Numerics;

namespace Floreria.Modelos
{
     public class Pedido
     {
        private LinkedList<Arreglofloral> _arregloflorales;
        public double Total
        {
            get
            {
                if (_arregloflorales == null)
                {
                    throw new InvalidOperationException("asd");
                }
                  double Total = 0;

                foreach (var Arrego in _arregloflorales)
                {

                    Total = Arrego.ObtenerCostoArreglo();
                }
                return Total;


            }
        }
        public double DescuentoAplicado
        {
            get
            {
                if (_arregloflorales == null)
                {
                    throw new InvalidOperationException("asd");
                }
                double Total = 0;

                foreach (var Arrego in _arregloflorales)
                {

                    Total = Arrego.ObtenerCostoArreglo() * 0.10;
                }
                return Total;
            }
        }



        public Pedido()
        {
            _arregloflorales = new LinkedList<Arreglofloral>();
            
        }
     }
}
