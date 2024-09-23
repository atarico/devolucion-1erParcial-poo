using System.Linq;

namespace Florencia.Models
{
    public class ArregloFloral
    {
        public List<Florcita> Flor {  get; private set; } = new List<Florcita>();

        public ArregloFloral(List<Florcita> flor) 
        {
            Flor = flor;
        }

        public void AgregarFlor(List<Florcita> flor)
        {
            foreach (Florcita TotalFlores in Flor)
            {
                Flor.Add(TotalFlores);
            }
        }

        public double ObtenerCostoArreglo()
        {
               
        }
    }
}
