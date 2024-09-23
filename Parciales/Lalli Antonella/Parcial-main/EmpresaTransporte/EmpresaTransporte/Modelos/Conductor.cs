
namespace EmpresaTransporte.Modelos
{
    public class Conductor
    {
        public string Nombre { get; private set; }
        public int LicenciaDeConducir { get; private set; }
        public DateTime FechaContratacion { get; private set; }
        

        public Conductor(string nombre, int licencia, DateTime fechacontratacion)
        {
            Nombre = nombre;
            LicenciaDeConducir = licencia;
            FechaContratacion = fechacontratacion;
           

        }
    }
}
