using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Modulos
{
    public class Instructor
    {
        public string Nombre { get; private set; }
        public int Experiencia { get; private set; }
        public Instructor(string nombre, int experiencia)
        {
            Nombre = nombre;
            Experiencia = experiencia;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre {Nombre}, Experiencia{Experiencia} años");

        }
    }
}
