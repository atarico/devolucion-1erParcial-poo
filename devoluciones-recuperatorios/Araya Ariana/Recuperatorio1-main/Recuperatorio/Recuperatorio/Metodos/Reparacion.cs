using Recuperatorio.Enum; 
namespace Recuperatorio.Metodos
{
    public class Reparacion
    {
        public int CostoFijo = 50;
        public Trabajo Trabajo { get; set; }
        public double Costototal
        {
            get
            {
                int i = 0;
                switch (Trabajo)
                {
                    case Trabajo.Electrico:
                        i = CostoFijo + 100;
                        break;
                    case Trabajo.Mecanico:
                        i = CostoFijo + 200;
                        break;
                    case Trabajo.Pintura:
                        i = CostoFijo + 150;
                        break;
                    default: return CostoFijo;
                }
            }
        }
        public Reparacion(Trabajo trabajo) 
        { 
        Trabajo = trabajo;
        }
    }
}
