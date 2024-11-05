namespace Floreria.Modulos
{
    public class Pedido
    {
        private List<ArregloFloral> _arregloFloral = new List<ArregloFloral>();
        public double Total { get; private set; }
        public bool DescuentoAplicado { get; private set; }
        public Pedido( double total)
        {
            Total = total;

        }
    }
}
