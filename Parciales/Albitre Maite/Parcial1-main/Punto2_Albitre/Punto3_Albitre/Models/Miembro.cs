using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3_Albitre.Models
{
    public class Miembro
    {
        public string NombreM { get; private set; }
        public int Numero { get; private set; }
        public List<Clase> _clases { get; private set; } = new List<Clase>();
        public Miembro(string nombre, int numero) 
        {
            NombreM = nombre;
            Numero = numero;
        }
        public void InscribirseAClase(Clase clase) 
        {
            _clases.Add(clase);
        }
        public double CostoTotal() 
        {
            double total = 0;
            foreach(Clase clase in _clases)
            {
                total += clase.Costo;
            }
            return total;
        }
        public void MostrarDetallesMiembro()
        {
            Console.WriteLine($"Miembro: {NombreM}\n Numero de Miembro: {Numero}\nClases en las que esta inscripto: \n");

            foreach(Clase clase in _clases)
            {
                clase.MostrarDetallesClase();
            }
            
        }
    }
}
