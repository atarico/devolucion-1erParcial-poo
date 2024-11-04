namespace Recuperatorio.Metodos
{
    public class Vehiculo
    {
        public string Marca { get;private set; }    
        public string Modelo { get;private set; }   
        public int Anio { get;private set; } 
        public Vehiculo(string marca, string modelo, int anio) 
        { 
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }
        public void MostrarDetalle()
        {
            Console.WriteLine($"El vehiculo {Marca}, Modelo: {Modelo} es del año: {Anio}");
        }

        
    }
}
