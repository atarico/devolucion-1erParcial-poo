using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3_Albitre.Models
{
    public class Instructor
    {
        public string Nombre { get; private set; }  
        public int Experiencia { get; private set; }
        public Instructor(string nombre, int exp) 
        {
            Nombre = nombre;
            Experiencia = exp;
        }
        public void MostrarDetallesInst()
        {
            Console.WriteLine($"Instructor: {Nombre}\n Experiencia: {Experiencia} años");
        }
    }
}
