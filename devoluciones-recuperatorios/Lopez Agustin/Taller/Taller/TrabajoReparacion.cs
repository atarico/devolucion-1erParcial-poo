using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    internal class TrabajoReparacion
    {
        public string DescripcionTrabajo { get { return DescripcionTrabajo; } private set { DescripcionTrabajo = value; } }
        public double CostoTrabajo { get { return CostoTrabajo; } private set { value = CostoTrabajo; } }
        public int TipoTrabajo {get { return TipoTrabajo; } private set { TipoTrabajo = value; } }
        
        TrabajoReparacion(string descripcionTrabajo, double costoTrabajo, int tipoTrabajo)
        {
            DescripcionTrabajo = descripcionTrabajo;
            CostoTrabajo = costoTrabajo;
            TipoTrabajo = tipoTrabajo;
        }

        

    }
}
