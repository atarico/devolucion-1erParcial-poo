using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Modulos
{
    public class Miembro
    {
        public string Nombre { get; private set; } 
        public int NumeroMiembro { get; private set; }
        public Miembro(string nombre,int numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, Numero Miembro {NumeroMiembro}");
        }
    }
}
