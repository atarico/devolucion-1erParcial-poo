namespace Floreria.Models
{
    public class ArregloFloral
    {
        public List<Flor> Flores { get; private set; } = new List<Flor>();

        public ArregloFloral(Flor flor) => Flores.Add(flor);
        public ArregloFloral(List<Flor> flores) => Flores.AddRange(flores);

        public double ObtenerCostoArreglo() => Flores.Sum((flor) => flor.Costo);
        public void AgregarFlor(Flor flor) => Flores.Add(flor);
        public void EliminarFlor(Flor flor) => Flores.Remove(flor);
    }
}
