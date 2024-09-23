namespace Gimnasio.Modulos
{
    public class Miembro
    {
        public string Nombre {  get; set; }
        public int NroMiembro { get; set; }
        public List<Clases> clases { get; private set; } = new List<Clases>();

        public Miembro(string nombre,int nroMiembro)
        {
            Nombre = nombre;   
            NroMiembro = nroMiembro;
        }
        

    }
}
