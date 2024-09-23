namespace GimnasioLocal.Modulos
{
    public class Instructor
    {
        private string _nombre;
        private int _experiencia;

        public string Nombre => _nombre;
        public int Experiencia => _experiencia;

        public Instructor(string nombre, int experiencia)
        {
            _nombre = nombre;
            _experiencia = experiencia;
        }
    }
}
