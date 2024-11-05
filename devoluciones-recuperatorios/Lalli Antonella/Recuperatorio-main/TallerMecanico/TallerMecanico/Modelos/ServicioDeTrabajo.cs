using TallerMecanico.Enum;

namespace TallerMecanico.Modelos
{
    public class ServicioDeTrabajo
    {
        public TipoDeReparacion TipoReparacion { get; private set; }
        public string Descripcion { get; private set; }
        public decimal CostoFijo { get; private set; }
        public Mecanico MecanicoAsociado { get; private set; }
        public string EspecialidadAsociada { get; private set; }


        public ServicioDeTrabajo(TipoDeReparacion tipoDeReparacion, string descripcion, decimal costo, string especialidad )
        {
            TipoReparacion = tipoDeReparacion;
            Descripcion = descripcion;
            CostoFijo = costo;
            EspecialidadAsociada = especialidad;
            MecanicoAsociado = null;
            
        }

        public void AsignarMecanico(Mecanico mecanico)
        {
             if (mecanico.Especialidad == EspecialidadAsociada)
             {
                 MecanicoAsociado = mecanico;

             }
             else
                {
                    throw new ArgumentException ("No existe mecanico para esa especialidad");
                }
          }

        }
    }


