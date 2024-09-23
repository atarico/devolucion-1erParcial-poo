using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2_Albitre.Models
{
    public class Pedido
    {
        public List<ArregloFloral> _arreglosFlorales { get; private set; } = new List<ArregloFloral>();
        public double Total
        {
            get 
            {
                double costoTotal= 0;
                foreach(ArregloFloral arreglo in _arreglosFlorales)
                {
                    costoTotal += arreglo.ObtenerCosto();
                }
                return Total;
            }
        }
        public bool DescuentoAplicado
        {
            get
            {
                if(_arreglosFlorales.Count < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Pedido() 
        {

        }
        public void AgregarArreglo(ArregloFloral arreglo) 
        {
            _arreglosFlorales.Add(arreglo);
        }
        public void QuitarArreglo(ArregloFloral arreglo)
        {
            _arreglosFlorales.Remove(arreglo);
        }
        public void MostrarDetallesPedido()
        {
            foreach(ArregloFloral arregloFloral in _arreglosFlorales)
            {
                Console.WriteLine("Pedido:\n");
                arregloFloral.MostrarDetallesArreglo();
            }
        }
    }
}
