using TallerMecanico.Enum;
namespace TallerMecanico.Modelos
{
    public class SistemaTaller
    {
        public string NombreTaller { get; private set; }
        public List<ServicioDeTrabajo> ServiciosTotales { get; private set; } = new List<ServicioDeTrabajo>();
        public List<Mecanico> MecanicosTotales { get; private set; } = new List<Mecanico>();
        public List<Cliente> ClientesTotales { get; private set; } = new List<Cliente>();


        public SistemaTaller(string nombre)
        {
            NombreTaller = nombre;
        }
        public void AgregarServicio(ServicioDeTrabajo servicio)
        {
            ServiciosTotales.Add(servicio);
        }
        public void AgregarMecanico(Mecanico m)
        {
            MecanicosTotales.Add(m);
        }
        public void ListarServicios()
        {
            foreach ( ServicioDeTrabajo ser in ServiciosTotales)
            {
                Console.WriteLine($"-{ser.Descripcion}");
            }
        }

        public void ElaborarPresupuesto(Cliente cliente)
        {
            decimal TarifaTotal = 0;
            foreach (Vehiculo v in cliente.Vehiculos)
            {
                foreach (ServicioDeTrabajo serv in v.serviciosRealizados)
                {
                     TarifaTotal += serv.CostoFijo;

                    switch (serv.TipoReparacion)
                    {
                        case TipoDeReparacion.Electrica:
                            TarifaTotal += 500;
                        break;

                        case TipoDeReparacion.Mecanica:
                            TarifaTotal += 600;
                            break;

                        case TipoDeReparacion.Pintura:
                            TarifaTotal += 700;
                            break;
                    }

                }
            }
            Console.WriteLine("----------------------------------------------------");
            cliente.MostrarVehiculos();
            Console.WriteLine($"Total a abonar ${TarifaTotal}");
            Console.WriteLine("----------------------------------------------------");
        }






    }
}
