namespace Florencia.Models
{
    public class Pedido
    {
        public List<ArregloFloral> ArreglosFlorales { get; private set; }
        public double Total 
        { 
            get 
            {
                double CostoTotal = 0;

                
                    foreach (ArregloFloral TotalArreglos in ArreglosFlorales)
                    {
                    CostoTotal = TotalArreglos.ObtenerCostoArreglo();
                    }

                    

                return Total;
            } 
        
        
        }

    }
}
