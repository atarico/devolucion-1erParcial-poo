
namespace Floreria.Modelos
{
    public class ArregloFloral
    {
        private List<Flor> _flores = new List<Flor>();


        public ArregloFloral(List<Flor> flores)
        {
            _flores = flores;
        }

        public void AgregarFlor(Flor flor)
        {
            _flores.Add(flor);
        }

        public double ObtenerCostoArreglo()
        {  
            double costo = 0;
            foreach (var flor in _flores)
            {
             Console.WriteLine($"{flor.Tipo}");
              costo += flor.Costo;
            }

            return costo;

        }

        

    }
}