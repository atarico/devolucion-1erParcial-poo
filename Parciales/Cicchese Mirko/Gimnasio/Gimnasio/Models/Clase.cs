namespace Gimnasio.Models
{
    public class Clase
    {
        public Instructor InstructorGym { get; set; }
        public string NombreClase { get; set; }
        public int Lugares { get; set; }
        public double Costo { get; set; }

        public Clase(Instructor instructor, string nombreClase, int lugares, double costo) 
        {
            InstructorGym = instructor;
            NombreClase = nombreClase;
            Lugares = lugares;
            Costo = costo;
        }
    }
}
