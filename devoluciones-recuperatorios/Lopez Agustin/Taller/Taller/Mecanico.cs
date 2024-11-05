using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    internal class Mecanico
    {


        private int CodigoMecanico;
       public Dictionary<string, int> CodigoMecanicoMap = new Dictionary<string, int>();
        public Mecanico(int codigoMecanico, string nombreEspecialidad, int tipoEspecialidad)
        {
            CodigoMecanico = codigoMecanico;
            CodigoMecanicoMap.Add(nombreEspecialidad, tipoEspecialidad);
        }



    }
}
