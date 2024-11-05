
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
     class Clase
    {

        public int LugaresDisponibles { get { return LugaresDisponibles; }  set { LugaresDisponibles = value; } }
        private double CostoClase;
        Instructor InstructorAsignado;

        Clase(double costoClase, int lugaresDisponibles, Instructor instructorAsignado)
        {
            CostoClase = costoClase;
            LugaresDisponibles = lugaresDisponibles;
            InstructorAsignado = instructorAsignado;
        }

        public void MostrarLugaresDisponibles()
        {
            Console.WriteLine($"Hay un total de {LugaresDisponibles} Lugares disponibles.");

        }
    }
}
