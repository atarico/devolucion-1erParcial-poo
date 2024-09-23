using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Floreria
{
    class Pedido
    {

       public List<ArregloFloral> Pedidito = new List<ArregloFloral>();

        
        Pedido(ArregloFloral ArregloFloral)
        {
            Pedidito.Add(ArregloFloral);
            
        }
        

    }
}
