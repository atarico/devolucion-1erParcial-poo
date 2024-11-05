using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2_Albitre.Models
{
    public class Flor
    {
        public string Tipo { get; private set; }
        public double Costo { get; private set; }
        public Flor(string tipo, double costo) 
        { 
            Tipo = tipo;
            Costo = costo;
        }
        public void MostrarDetallesFlor()
        {
            Console.WriteLine($"Tipo Flor: {Tipo}\n Coste: {Costo}\n");
        }
    }
}
