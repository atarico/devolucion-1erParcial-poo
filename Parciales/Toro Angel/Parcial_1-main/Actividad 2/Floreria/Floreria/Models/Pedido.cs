namespace Floreria.Models
{
    public class Pedido
    {
        public List<ArregloFloral> ArregloFlores { get; private set; } = new List<ArregloFloral>();

        public bool DescuentoAplicado()
        {
            int cont = 0;
            foreach (var item in ArregloFlores)
            {
                cont++;
            }
            if (cont > 5)
            {
                return true;
            }
            else { return false; }
        }

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in ArregloFlores)
                {
                    total += item.ObtenerCostoArreglo();
                }
                if (!DescuentoAplicado())
                {
                    return total;
                }
                else { return total * 0.9; }
            }
        }

        public void AgregarArregloFloral(ArregloFloral arregloFloral)
        {
            ArregloFlores.Add(arregloFloral);
        }

        public void AgregarArregloFloral(List<ArregloFloral> arregloFloral)
        {
            ArregloFlores.AddRange(arregloFloral);
        }
    }
}
