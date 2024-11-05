namespace Floreria.Models
{
    public class Pedido
    {
        public List<ArregloFloral> ArreglosFlorales { get; private set; } = new List<ArregloFloral>();

        public double Total => ArreglosFlorales.Sum((arregloFloral) => arregloFloral.ObtenerCostoArreglo());

        public bool DescuentoAplicdo => ArreglosFlorales.Count > 5;

        public Pedido(ArregloFloral arregloFloral)
        {
            ArreglosFlorales.Add(arregloFloral);
        }

        public Pedido(List<ArregloFloral> arreglosFlorales)
        {
            arreglosFlorales.AddRange(ArreglosFlorales);
        }
    }
}
