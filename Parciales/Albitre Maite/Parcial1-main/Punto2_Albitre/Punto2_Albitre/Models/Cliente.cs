using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2_Albitre.Models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido PedidoCl { get; private set; }
        public Cliente(string nombre, Pedido pedidoCl) 
        {
            Nombre = nombre;
            PedidoCl = pedidoCl;
        }
        public void MostrarResumenPedido()
        {
            Console.WriteLine("Este es el resumen de tu pedido:\n");
            PedidoCl.MostrarDetallesPedido();

        }
    }
}
