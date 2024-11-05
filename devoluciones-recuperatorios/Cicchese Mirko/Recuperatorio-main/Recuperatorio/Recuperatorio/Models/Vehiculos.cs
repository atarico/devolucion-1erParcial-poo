using Recuperatorio.Enums;

namespace Recuperatorio.Models
{
    public class Vehiculos
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Año { get; private set; }
        public List<Trabajo> Servicio { get; private set; } = new List<Trabajo>();

        public double TotalArreglos 
        { 
            get 
            {
                
                double total = 0;

                foreach (var trabajo in Servicio)
                    {
                        total += trabajo.CostoServicio;
                    }
                    return total;
                
            } 
        }

        public Vehiculos(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public void TrabajoXAuto(Trabajo trabajo)
        {
            Servicio.Add(trabajo);
        }
    }
}
