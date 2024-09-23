
namespace Floreria.Modelos
{
    public class Pedido
    {  
        private List<ArregloFloral> _arreglosFlorales = new List<ArregloFloral>();
        private bool _descuentoAplicado { get; set; } = false;
        public Pedido(List<ArregloFloral> arreglosFlorales, bool descuento)
        {
            _arreglosFlorales = arreglosFlorales;
            _descuentoAplicado = descuento;
        }


        public double ObtenerTotal(List<ArregloFloral> _arreglos)
        {
            double costo = 0;
            foreach (var arreglo in _arreglos)
            {

                costo += arreglo.ObtenerCostoArreglo();

            }
               
            if (_arreglos.Count > 5)

                {  
                    costo-= (10 / 100) * costo;
                }

            return costo;

        }


        }
    }

