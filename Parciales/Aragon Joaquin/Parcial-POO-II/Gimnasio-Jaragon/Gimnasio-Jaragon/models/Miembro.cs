
namespace Gimnasio_Jaragon.models
{
    public class Miembro
    {
        public readonly int numeroContador = 0;
        public string Nombre { get; private set; }
        public List<Clase> Clases { get; private set; } = new List<Clase>();
        public int NroMiembro { get; private set; }

        public Miembro(string nombre)
        {
            Nombre = nombre;
            NroMiembro = ++numeroContador;
        }

        public void UniseClase(Clase clase) {
            if (clase.LugaresDisponibles >= 1)
            {
                Clases.Add(clase);
                clase.QuitarLugar();
            }
            else throw new ArgumentException("No hay espacios disponibles para anotarse a esta clase");
        }
        public void UniseClase(List<Clase> clases) {
            foreach (var clase in clases) {
                UniseClase(clase); 
            }
        }

        public void SalirClase(Clase clase) {
            Clases.Remove(clase);
            clase.AñadirLugar();
        }
                
        public void SalirClase(List<Clase> clases)
        {
            foreach (var clase in clases) { SalirClase(clase); }
        }
    }
}
