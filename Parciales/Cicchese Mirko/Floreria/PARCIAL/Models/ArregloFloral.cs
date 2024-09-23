namespace PARCIAL.Models
{
    public class ArregloFloral
    {
        public List<Flor> Flores { get; private set; } = new List<Flor>();

        public ArregloFloral() 
        {
            Flores = new List<Flor>();
        }
        public ArregloFloral(Flor flor)
        {
            Flores.Add(flor);
        }

        public void AgregarFlor(Flor flor)
        {
            Flores.Add(flor);
        }
        public double ObtenerCostoArreglo()
        {
            double Costo = 0;
            foreach (var flor in Flores)
            {
                Costo += flor.Costo;
            }
            return Costo;
        }
    }
}
