using Gimnasio.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gimnasio;
namespace Gimnasio
{
    class Miembro
    {
        private string Nombre;
        private int CodigoMiembro;

        Miembro(string nombre, int codigoMiembro)
        {
            Nombre = nombre;
            CodigoMiembro = codigoMiembro;
        }

        public void MiembroInscribirse(Clase clasecita)
        {
            if (clasecita.LugaresDisponibles != 0)
            {
                clasecita.LugaresDisponibles--;
                Console.WriteLine($"Inscripto en la clase con éxito.");
            }
            throw new Exception($"No se pudo anotar porque no hay cupos :(");
        }
        public void MiembroDesinscribirse(Clase clasecita)
        {
            clasecita.LugaresDisponibles++;

            Console.WriteLine($"Clase desanotada con éxito.");
        }


    }
}
