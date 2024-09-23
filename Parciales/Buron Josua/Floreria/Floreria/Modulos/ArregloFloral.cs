namespace Floreria.Modulos
{
    public class ArregloFloral
    {
        public List<Flor> _flores { get; private set; } = new List<Flor>();
    public ArregloFloral(List<Flor> flor)
        {
            _flores = flor;
        }
        //public double CostoTotalArreglo
        //{
        //    get
        //    {
        //        double Costototal = 0;
        //        foreach (var flor in Flor)
        //        {
        //            Costototal += flor.costo++;
        //        }
        //        return Costototal;
        //    }
        //}
    }
}
