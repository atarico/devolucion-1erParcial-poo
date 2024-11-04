namespace TallerMecanico.Modelos
{
    public class Vehiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Año { get; private set; }
        public string Patente { get; private set; }

        public List<ServicioDeTrabajo>serviciosRealizados = new List<ServicioDeTrabajo>();

        public Vehiculo(string marca, string modelo, int año, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            Año = año;
        }

        public void AgregarServicio(ServicioDeTrabajo servicio)
        {
            serviciosRealizados.Add(servicio);
        }

    }
}
