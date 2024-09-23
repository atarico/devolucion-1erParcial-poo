namespace Floreria.Models
{
    public class ArregloFloral
    {
        public List<Flor> Flores { get; private set; } = new List<Flor>();

        public void AgregarFlores(Flor flores)
        {
            Flores.Add(flores);
        }

        public void AgregarFlores(List<Flor> flores)
        {
            Flores.AddRange(flores);
        }

        public double ObtenerCostoArreglo()
        {
            double total = 0;
            foreach (var flor in Flores)
            {
                total += flor.Costo;
            }
            return total;
        }
    }
}
