

namespace Ejercicio2.Models
{
    public class ArregloFloral
    {
        public List<Flor> Flores { get; set; }
        public ArregloFloral(Flor flor)
        {
            Flores = new List<Flor>();
        }
        public void AgregarFlor(Flor flor) 
        {
            Flores.Add(flor);
        }
        public void AgregarFlor(List<Flor> flor)
        {
            Flores.AddRange(flor);
        }
        public double ObtenerCostoArreglo() 
        {
            double costo= 0;
            foreach (Flor flor in Flores) 
            {
                costo =+ flor.Costo;
            }
            return costo;
        }
    }
}
