
namespace Floreria_Parcial_JAragon.models
{
    public class Flor
    {
        public string Tipo { get; private set; }
        public double Costo { get; private set; }

        public Flor(string tipo, double costo)
        {
            this.Tipo = tipo;
            this.Costo = costo;
        }  
    }
}
