namespace Gimnasio.Modulos
{
    public class Instructor
    {
        public string Nombre {  get; set; }
        public int Experiencia {  get; set; }

        public Instructor(string nombre, int experiencia)
        {
            Nombre = nombre;
            Experiencia = experiencia;
        }
       
    }
}
