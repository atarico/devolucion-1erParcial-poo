using Recuperatorio.Enum;

namespace Recuperatorio.Modelos
{
    public class TrabajoReparacion
    {
        public Mecanico Mecanico { get;private set; }
        public TipoTrabajo TipoTrabajo { get; private set; }
        public double CostoTrabajo
        {
            get
            {
                switch (TipoTrabajo)
                {
                    case TipoTrabajo.Electricidad:
                        return 5000;
                    case TipoTrabajo.Mecanico:
                        return 10000;
                    case TipoTrabajo.Pintura:
                        return 15000;
                    default:
                        return 0;
                }
            }
        }



        public TrabajoReparacion(Mecanico mecanico, TipoTrabajo tipoTrabajo, double costo)
        {
            Mecanico = mecanico;
        }
        public void MostrarDetallesReparacion()
        {
            Console.WriteLine($"Trabajo realizado {TipoTrabajo} por un costo de {CostoTrabajo}");
        }
    }
}
