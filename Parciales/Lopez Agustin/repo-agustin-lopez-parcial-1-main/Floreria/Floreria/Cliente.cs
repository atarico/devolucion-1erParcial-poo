using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floreria
{
     class Cliente
    {
        private string Nombre;
        private Pedido Pedilo;
        Cliente(string nombre,  Pedido pedilo)
        {
            Nombre = nombre;
            Pedilo = pedilo;
        }

        public void MostrarResumenPedido()
        {
            int i = 0;
            double SumaTotal = 0;
            bool DescuentoAplicable = false;
            foreach (ArregloFloral arreglo in Pedilo.Pedidito)
            {
                i++;
            }
            if (i >= 5)
            {
                 DescuentoAplicable = true;
            }

            foreach (ArregloFloral arreglo in Pedilo.Pedidito)
            {
                SumaTotal =+ arreglo.ObtenerCostoArreglo();
            }

            if (DescuentoAplicable)
            {
                Console.WriteLine($"El precio sumado de los arreglos pedidos es: {SumaTotal}. Debido a tener un descuento por cantidad, el precio final es {SumaTotal * 0.1}.");
            }
            Console.WriteLine($"El precio final por los arreglos pedidos es: {SumaTotal}. ");
        }
    }
}
