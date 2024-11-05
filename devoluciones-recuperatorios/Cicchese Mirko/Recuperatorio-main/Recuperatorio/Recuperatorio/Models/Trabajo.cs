using Recuperatorio.Enums;

namespace Recuperatorio.Models
{
    public class Trabajo
    {
        public Servicios Descripcion { get; private set; }
        public double CostoServicio { get; private set; }

        public Mecanico Mecanico { get; private set; }

        public Trabajo(Servicios descripcion, double costoServicio)
        {
            Descripcion = descripcion;
            CostoServicio = costoServicio;
        }

        public void VerificarEspecialidad(Mecanico mecanico, Servicios descripcion)
        {
            if(mecanico.EspecialidadMecanico == Especialidad.MecanicaGeneral && descripcion == Servicios.CambioDeAceite)
            {
                Console.WriteLine($"El mecanico con especialidad en {Especialidad.MecanicaGeneral} se esta haciendo cargo de su vehiculo");
            }
            if(mecanico.EspecialidadMecanico == Especialidad.ReparacionElectica && descripcion == Servicios.ArregloLuces)
            {
                Console.WriteLine($"El mecanico con especialidad en {Especialidad.ReparacionElectica} se esta haciendo cargo de su vehiculo");
            }
            if(mecanico.EspecialidadMecanico == Especialidad.Pintura && descripcion == Servicios.PinturaCompleta)
            {
                Console.WriteLine($"El mecanico con especialidad en {Especialidad.Pintura} se esta haciendo cargo de su vehiculo");
            }
            else
            {
                Console.WriteLine("El mecanico seleccionado tiene otra especialidad");
            }
        }
    }
}
