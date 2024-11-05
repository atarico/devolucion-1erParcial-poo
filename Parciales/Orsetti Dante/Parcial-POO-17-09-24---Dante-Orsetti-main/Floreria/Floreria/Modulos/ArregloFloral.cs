namespace Floreria.Modulos
{
    public class ArregloFloral
    {
        private List<Flor> _flores = new List<Flor>();
        public List<Flor> Flores => _flores;

        public ArregloFloral(List<Flor> flores)
        {
            _flores = flores;
        }
        public ArregloFloral(Flor flor)
        {
            AgregarFlor(flor);
        }

        public double ObtenerCostoArreglo()
        {
            double costoArreglo = 0;
            foreach (var flor in _flores)
            {
                costoArreglo += flor.Costo;
            }
            return costoArreglo;
        }

        public void AgregarFlor(Flor flor)
        {
            _flores.Add(flor);
        }

        public void AgregarFlor(List<Flor> flores)
        {
            _flores.AddRange(flores);
        }

        public void QuitarFlor(Flor flor)
        {
            _flores.Remove(flor);
        }
    }
}
