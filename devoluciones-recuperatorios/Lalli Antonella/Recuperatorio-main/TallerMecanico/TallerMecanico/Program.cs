
using TallerMecanico.Enum;
namespace TallerMecanico.Modelos
{
    class Program
    {
        static void Main()
        {
            Mecanico Juan = new Mecanico("Juan Perez", "Pintura");
            Mecanico Juancito = new Mecanico("Juan Perecito", "Electricidad");
            Mecanico Juanzote = new Mecanico("Juan Perezon", "Mecanica");

            ServicioDeTrabajo servicio = new ServicioDeTrabajo(TipoDeReparacion.Mecanica, "Cambio de motor", 500, "Mecanica");
            servicio.AsignarMecanico(Juanzote);
            ServicioDeTrabajo servicio2 = new ServicioDeTrabajo(TipoDeReparacion.Electrica, "Cambio de aceite", 600, "Electricidad");
            ServicioDeTrabajo servicio3 = new ServicioDeTrabajo(TipoDeReparacion.Mecanica, "Cambio de color", 700, "Pintura");
            servicio3.AsignarMecanico(Juancito);


            SistemaTaller NuevoSist = new SistemaTaller("JUANES");
            NuevoSist.AgregarMecanico(Juan);
            NuevoSist.AgregarMecanico(Juancito);
           NuevoSist.AgregarMecanico(Juanzote);

            NuevoSist.AgregarServicio(servicio);
            NuevoSist.AgregarServicio(servicio2);
            NuevoSist.AgregarServicio(servicio3);

            NuevoSist.ListarServicios();
            Vehiculo Auto = new Vehiculo("UNAMARCA", "UNMODELO", 2024, "ABC123");
            Cliente cliente = new Cliente("JUAN PERESOTE", 12, new List<Vehiculo> { Auto });
            Auto.AgregarServicio(servicio);
            Auto.AgregarServicio(servicio3);
            NuevoSist.ElaborarPresupuesto(cliente);


        }
        }
    }
