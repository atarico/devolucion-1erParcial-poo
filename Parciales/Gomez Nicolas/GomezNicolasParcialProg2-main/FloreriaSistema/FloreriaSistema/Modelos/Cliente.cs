using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloreriaSistema.Modelos

{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido Pedido { get; private set; } 

        public Cliente(string nombre, Pedido pedido)
        {
            Pedido = pedido;
            Nombre = nombre;
        }
        public void MostrarResumenPedido()
        {
            Console.WriteLine($"Cliente: {Nombre}");
            Pedido.MostrarDetalles();
            
        }

    }
}
