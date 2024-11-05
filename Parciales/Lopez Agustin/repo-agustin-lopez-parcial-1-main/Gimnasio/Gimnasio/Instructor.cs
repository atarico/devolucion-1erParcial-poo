using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
     class Instructor
    {
        private string Nombre;
        private string Experiencia;
        List<Clase> ClasesAsignadas = new List<Clase>();
        Instructor(string nombre, string experiencia)
        {
            Nombre = nombre;
            Experiencia = experiencia;

        }
        Instructor(Clase clase)
        {
            ClasesAsignadas.Add(clase);
        }

    }
}
