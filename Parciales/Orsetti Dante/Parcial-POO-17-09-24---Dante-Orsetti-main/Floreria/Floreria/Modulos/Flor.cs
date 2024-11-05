namespace Floreria.Modulos
{
    public class Flor
    {
        private string _tipo;
        private double _costo;
        public string Tipo => _tipo;
        public double Costo => _costo;

        public Flor(string tipo, double costo)
        {
            _tipo = tipo;
            _costo = costo;
        }
    }
}
