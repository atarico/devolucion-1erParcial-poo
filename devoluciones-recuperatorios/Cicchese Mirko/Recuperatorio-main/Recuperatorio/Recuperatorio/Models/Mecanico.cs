using Recuperatorio.Enums;

namespace Recuperatorio.Models
{
    public class Mecanico
    {
        public Especialidad EspecialidadMecanico { get; private set; }

        public Mecanico(Especialidad especialidad)
        {
            EspecialidadMecanico = especialidad;
        }
    }
}
