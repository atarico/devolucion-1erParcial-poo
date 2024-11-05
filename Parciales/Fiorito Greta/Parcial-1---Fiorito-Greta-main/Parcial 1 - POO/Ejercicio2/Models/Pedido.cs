
namespace Ejercicio2.Models
{
    public class Pedido
    {
        public List<ArregloFloral> ArreglosFlorales { get; private set; }   
        public double Total { 
            get {
                double total = Total;
                if (DescuentoAplicado == true) 
                {
                    total = total * 0.9;
                }
                return total;
            } 
        }
        public bool DescuentoAplicado { 
            get {
                bool descuento = false;
                int contador = 0;
                foreach (var flor in ArreglosFlorales) {
                    contador++;
                }
                if (contador >= 6) 
                {
                     descuento = true;
                }
                return descuento;
            }
        }
        public Pedido(ArregloFloral arregloFloral)
        {
            ArreglosFlorales = new List<ArregloFloral>(); ;
        }
        public void AgregarArreglo(ArregloFloral arreglo) 
        {
            ArreglosFlorales.Add(arreglo);
        }
        public void AgregarArreglo(List<ArregloFloral> arreglo)
        {
            ArreglosFlorales.AddRange(arreglo);
        }
    }
}
