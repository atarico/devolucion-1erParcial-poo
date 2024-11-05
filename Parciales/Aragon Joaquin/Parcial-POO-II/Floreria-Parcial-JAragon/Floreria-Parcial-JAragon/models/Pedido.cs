
namespace Floreria_Parcial_JAragon.models
{
    public class Pedido
    {
        public List<ArregloFloral> ArreglosFlorares { get; private set; } = new List<ArregloFloral>();
        public bool DescuentoAplicado
        {
            get
            {
                return ArreglosFlorares.Count >= 5 ? true : false;
            }
            private set { }
        }
        public double Total { get
            {
                double costoFinal = 0;
                foreach (var arregloFloral in ArreglosFlorares)
                {
                    costoFinal += arregloFloral.ObetenerCostoArreglo();
                }
                return DescuentoAplicado ? costoFinal * 0.90 : costoFinal;

            } private set { }
        }

       

        public void AñadirArregloFloral(ArregloFloral ArregloFloral) => ArreglosFlorares.Add(ArregloFloral);
        public void AñadirArregloFloral(List<ArregloFloral> ArregloFloral)
        {
            foreach (var arregloFloral in ArregloFloral)
            {
                ArreglosFlorares.Add(arregloFloral);
            }
        }

    }
}
