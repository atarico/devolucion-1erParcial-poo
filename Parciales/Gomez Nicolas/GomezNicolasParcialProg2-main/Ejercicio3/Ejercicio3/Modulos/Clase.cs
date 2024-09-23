using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Modulos
{
    public class Clase
    {
        public string Nombre { get; private set; }
        public double Costo { get; private set; }
        public List<Miembro> Miembros { get; private set; } = new List<Miembro>();
        public Instructor Instructor { get; private set; }
        public int LugaresDisponibles { get; private set; }
        
        public Clase(string nombre, double costo,int lugaresDisponibles, Instructor instructor)
        {
            Nombre = nombre;
            Costo = costo;
            LugaresDisponibles = lugaresDisponibles;
            Instructor = instructor;
        }
        public void AgregarMiembro(Miembro miembro)
        {
            if (LugaresDisponibles > 0)
            {
                Miembros.Add(miembro);
                LugaresDisponibles = LugaresDisponibles - 1;
            }
            else
            {
                Console.WriteLine("La clase esta llena!");
            }
            
        }
        public void AgregarMiembro(List<Miembro> miembros)
        {
            if (LugaresDisponibles >= miembros.Count)
            {
                Miembros = miembros;
                LugaresDisponibles = LugaresDisponibles - miembros.Count;
            }
            else
            {
                Console.WriteLine("La clase esta llena!");
            }

        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Costo: {Costo}");
            foreach(var miembro in Miembros)
            {
                miembro.MostrarDetalles();
            }
            Instructor.MostrarDetalles();

            Console.WriteLine($"Lugares Disponibles: {LugaresDisponibles}");
        }
    }
}


