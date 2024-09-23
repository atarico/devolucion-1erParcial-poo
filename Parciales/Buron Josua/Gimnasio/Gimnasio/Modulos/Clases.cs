namespace Gimnasio.Modulos
{
    public class Clases
    {
        public int CostoClase { get; set; }
        public int CantidadDisponible {  get; set; }
        public Clases(int costoClase,int cantidadDisponible)
        {
            CostoClase = costoClase;
            CantidadDisponible = cantidadDisponible;
        }

    }
}
