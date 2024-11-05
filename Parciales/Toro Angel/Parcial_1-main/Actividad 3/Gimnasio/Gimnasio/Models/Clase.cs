namespace Gimnasio.Models
{
    public class Clase
    {
        public string Nombre { get; private set; }
        public Instructor Instructor { get; private set; }
        public List<Miembro> Miembros { get; private set; } = new List<Miembro>();
        public int LugaresDisponible { get; private set; }
        public double Costo { get; private set; } 

        public Clase(Instructor instructor, int lugaresDisponible, double costo, string nombre)
        {
            Instructor = instructor;
            LugaresDisponible = lugaresDisponible;
            Costo = costo;
            Nombre = nombre;
        }

        public void AgregarMiembro(Miembro miembro)
        {
            if (LugaresDisponible > 0) 
            { 
                Miembros.Add(miembro); 
                LugaresDisponible -= 1;
            }
            else { throw new ArgumentException("No hay lugares disponibles"); }
        }
    }
}
