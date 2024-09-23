namespace Florencia.Models
{
    public class Florcita
    {
        public string Tipo {  get; private set; }
        public double Coste { get; private set; }

        public Florcita (string Tipo, double Coste)
        {
            this.Tipo = Tipo;
            this.Coste = Coste;
        }

    }
}
