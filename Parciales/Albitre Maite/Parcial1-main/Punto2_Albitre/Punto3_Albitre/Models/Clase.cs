using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3_Albitre.Models
{
    public class Clase
    {
        public string NombreClase { get; private set; }
        public int LugaresDisponibles { get; private set; }
        public double Costo { get; private set; }
        public Instructor InstructorCl { get; private set; }
        public Clase(string nombre, int lugares, double costo, Instructor instructor) 
        {
            NombreClase = nombre;
            LugaresDisponibles = lugares;
            Costo = costo;
            InstructorCl = instructor;
        }
        public void ActualizarLugares()
        {
            LugaresDisponibles--;
        }
        public void MostrarDetallesClase()
        {
            Console.WriteLine($"Clase: {NombreClase}\n Lugares Disponibles: {LugaresDisponibles} \nCosto: {Costo}\n");
            InstructorCl.MostrarDetallesInst();
        }

    }
}
