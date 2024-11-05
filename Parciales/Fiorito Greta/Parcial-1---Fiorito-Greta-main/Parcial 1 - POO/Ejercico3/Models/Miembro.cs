
using System.ComponentModel;

namespace Ejercico3.Models
{
    public class Miembro
    {
        public string Nombre { get; private set; }
        public int NroMiembro { get; private set; }
        public List<Clase> Clases { get; private set; } = new List<Clase>();

        public Miembro(string nombre, int nroMiembro) 
        {
            Nombre = nombre;
            NroMiembro = nroMiembro;
        }

        public void AgregarClaseMiembro(Clase clase) 
        {
            if (clase.ActualizarCupo(1) >= 0) 
            {
                Clases.Add(clase);
            }

               
        }
        public void AgregarClaseMiembro(List<Clase> clases)
        {
            int contador = 0;
            foreach (var clase in clases)
            {
                if (clase.ActualizarCupo(1) >= 0)
                {
                    Clases.Add(clase);
                }
                else 
                {
                    clase.ActualizarCupo(1);
                }
            }
            
        }
        public void MostrarDetallesMiembro(List<Clase> clases) 
        {
            double costototal = 0;
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"Detalles del miembro {NroMiembro}: {Nombre}");
            Console.WriteLine($"Atiende: ");
            foreach (var clase in clases) 
            {
                Console.WriteLine($"Clase: {clase.Nombre} ");
                Console.WriteLine($"Instructor: {clase.Instructor.Nombre}");
                Console.WriteLine($"Costo: ${clase.Costo} \n");
                costototal = costototal + clase.Costo;
            }
            Console.WriteLine($"Costo total: ${costototal}");
            Console.WriteLine($"-----------------------------------------------");
        }

    }
}
