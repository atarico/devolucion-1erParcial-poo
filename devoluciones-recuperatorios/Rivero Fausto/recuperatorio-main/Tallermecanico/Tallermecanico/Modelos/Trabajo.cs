using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tallermecanico.Enums;

namespace Tallermecanico.Modelos
{
    public class Trabajo
    {
        public double Costo { get; private set; }
        public string Descripcion { get; private set; }

        public Vehiculo VehiculoE { get; private set; }

        public mecanico mecanicoe { get; private set; }

        public Trabajo(double costo, string descripcion, Vehiculo vehiculoE, mecanico mecanicoe)
        {
            Costo = costo;
            Descripcion = descripcion;
            VehiculoE = vehiculoE;
            this.mecanicoe = mecanicoe;
        }

        public Tiporeparacion tiporeparacion
        {
            get
            {
                if (tiporeparacion == null)
                {
                    throw new InvalidOperationException("ingrese una reparacion");
                }

                double baseprecio;

                switch (VehiculoE.Tiporeparacions)
                {
                    case Tiporeparacion.electrica:
                        baseprecio = 100;
                        break;

                    case Tiporeparacion.pintura:
                        baseprecio = 200;
                        break;
                    case Tiporeparacion.mecanica:
                        baseprecio = 300;
                        break;
                    default:
                        throw new Exception("el tipo de reparacion no existe");
                }
            }
        }

        public void AsignarReparacion()
        {
            Console.WriteLine($"la repracion es al vehiculo:{VehiculoE.Marca},{VehiculoE.Año_vehiculo},{VehiculoE.Modelo},{Costo},{VehiculoE.Tiporeparacions}");
        }
        public void AsignarMecanico()
        {
            Console.WriteLine($"el mecanico es{mecanicoe.Nombre},y su especialidad es {TipoEspecialidad}");
        }
    }
}
            
        
    
      