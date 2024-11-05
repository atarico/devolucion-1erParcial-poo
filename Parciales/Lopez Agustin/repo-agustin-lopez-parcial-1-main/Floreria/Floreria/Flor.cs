using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Floreria
{
     class Flor
    {
        private string Tipo;
        public double Costo {  get { return Costo; } private set { Costo = value; } }

        Flor(string tipo, double costo)
        {
            Tipo = tipo;
            Costo = costo;
        }


    }
}
