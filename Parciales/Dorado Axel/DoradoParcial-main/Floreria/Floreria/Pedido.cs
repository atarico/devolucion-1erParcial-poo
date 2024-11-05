using System.Security.Cryptography.X509Certificates;

namespace Floreria
{
    public class Pedido
    {
        private List<ArregloFloral> arreglosFlorales;
        public Pedido()
        {
            arreglosFlorales = new List<ArregloFloral>();
        }
        public double CantidadPedido() 
        { 
            double acum1 = 0;
            foreach (var ArregloFloral in arreglosFlorales)
            {
                acum1 += arreglosFlorales.Count;
            }
            return acum1;
            
        }
      
    }
}
