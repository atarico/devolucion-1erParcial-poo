
namespace PARCIAL.Models
{
    public class Pedido
    {
        public List<ArregloFloral> ArreglosFlorales { get; private set; } = new List<ArregloFloral>();
        public double Total
        {
            get
            {
                double CostoTotal = 0;
                foreach (var arreglo in ArreglosFlorales)
                {
                    CostoTotal += arreglo.ObtenerCostoArreglo();
                }
                
                return CostoTotal;
            }
        }
        public bool DescuentoAplicado { 
            
            get
            {
                return ArreglosFlorales.Count > 5;
            }
        
        }

        public Pedido()
        {
            ArreglosFlorales = new List<ArregloFloral>();
        }

        public Pedido(ArregloFloral arregloFloral)
        {
            ArreglosFlorales.Add(arregloFloral);
        }

    }
}
