
namespace Floreria_Parcial_JAragon.models
{
    public class ArregloFloral
    {
        public List<Flor> Flores { get; private set; } = new List<Flor>();

        //Obetener estaba en el diagrama, no es un misstype
        public double ObetenerCostoArreglo()
        {
            double precioFinal = 0;
            foreach (var flor in Flores) { precioFinal += flor.Costo; }
            return precioFinal;
        }

        public void AñadirFlor(Flor flor) => Flores.Add(flor);
        public void AñadirFlor(List<Flor> flor)
        {
            foreach (var florcita in flor) { Flores.Add(florcita); }
        }

        //podria añadir un manejo de errores si no encuentra la flor
        public void RemoverFlor(Flor flor) => Flores.Remove(flor);
    }
}
