namespace Floreria.Modulos
{
    public class Pedido
    {
        private List<ArregloFloral> _arreglosFlorales = new List<ArregloFloral>();
        private double _total;
        private bool _descuentoAplicado;

        public List<ArregloFloral> ArreglosFlorales => _arreglosFlorales;
        public double Total
        {
            get
            {
                double total = 0;
                foreach(var arreglo in _arreglosFlorales)
                {
                    total += arreglo.ObtenerCostoArreglo();
                }
                if(_arreglosFlorales.Count > 5)
                {
                    return total - total * 0.1;
                }
                return total;
            }
        }
        public bool DescuentoAplicado
        {
            get
            {
                if (_arreglosFlorales.Count > 5)
                {
                    return true;
                }
                return false;
            }
        }
        
        public Pedido(List<ArregloFloral> arreglos)
        {
            _arreglosFlorales = arreglos;
        }
        public Pedido(ArregloFloral arreglo)
        {
            _arreglosFlorales.Add(arreglo);
        }

        public void AgregarArreglo(ArregloFloral arreglo)
        {
            _arreglosFlorales.Add(arreglo);
        }
        public void AgregarArreglo(List<ArregloFloral> arreglos)
        {
            _arreglosFlorales.AddRange(arreglos);
        }
        public void QuitarArreglo(ArregloFloral arreglo)
        {
            _arreglosFlorales.Remove(arreglo);
        }
    }
}
