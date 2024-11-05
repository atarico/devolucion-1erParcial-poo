using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FloreriaSistema.Modelos
{
    public class Pedido
    {
        public List<ArregloFloral> ArregloFlorales { get; private set; } = new List<ArregloFloral>();
       
        public bool DescuentoAplicado 
        {
            get { 
               if(ArregloFlorales.Count > 5)
                {
                    return true;
                }
                else { return false; }
            }
            private set { 
                DescuentoAplicado = value;
            }
         }
        public double Total
        {

            get
            {
                double total = 0;
                foreach (ArregloFloral arregloFloral in ArregloFlorales)
                {
                    total = total + arregloFloral.ObtenerCostoArreglo();
                };
                if (DescuentoAplicado)
                {
                    return total - total * 0.1;
                }
                else
                {
                    return total;
                }
            }
            private set
            {
                Total = value;
            }

        }
        public Pedido(ArregloFloral arregloFloral)
        {
            ArregloFlorales.Add(arregloFloral);
        }
        public Pedido(List<ArregloFloral> arregloFlorales)
        {
            ArregloFlorales = arregloFlorales;
        }

        public void MostrarDetalles()
        {
          
           Console.WriteLine($"Cantidad de Arreglos: {ArregloFlorales.Count}");
            foreach(ArregloFloral arregloFloral in ArregloFlorales)
            {
                arregloFloral.MostrarDetalles();
            }
            if (DescuentoAplicado)
            {
                Console.WriteLine("Hay descuento aplicado");
            }else
            {
                Console.WriteLine(" No hay descuento aplicado");
            }
            Console.WriteLine($" Precio Pedido {Total}");
            
        }


    }
}
