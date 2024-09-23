using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnacio.Modelos
{
    public class Clase
    {
        public Instructor Instructor;
        public double Costo { get; private set; }
        public bool Disponibilidad { get; private set; }
        public int LugarDisponible { get; private set; }


        public Clase(Instructor instructor, double costo, int lugardisponible)
        {
            Instructor = instructor;
            Costo = costo;
            Disponibilidad = true;
        }
            
        public void ConsultarLugar ()
        {
            LugarDisponible = 0;
            
            if (Disponibilidad = true)
            {
                LugarDisponible += 1;
            }
            else
            {
                Console.WriteLine("No hay lugar");
            }
        }

    }
}
