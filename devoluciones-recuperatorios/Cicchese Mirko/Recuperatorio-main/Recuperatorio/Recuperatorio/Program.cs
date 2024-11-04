using Recuperatorio.Enums;
using Recuperatorio.Models;

class Program
{
    static void Main()
    {

        //Creacion Mecanicos
        Mecanico mecanico1 = new Mecanico(Especialidad.MecanicaGeneral);
        Mecanico mecanico2 = new Mecanico(Especialidad.ReparacionElectica);
        Mecanico mecanico3 = new Mecanico(Especialidad.Pintura);

        //Creacion Trabajos
        Trabajo Frenos = new Trabajo(Servicios.ArregloLuces, 200);
        Trabajo Aceite = new Trabajo(Servicios.CambioDeAceite, 50);
        Trabajo Motor = new Trabajo(Servicios.PinturaCompleta, 500);

        //Creacion Clientes
        Cliente cliente1 = new Cliente(24);
        Cliente cliente2 = new Cliente(31);
        Cliente cliente3 = new Cliente(85);

        //Creacion Vehiculos
        Vehiculos Hilux = new Vehiculos("Toyota","Hilux", 2019);
        Vehiculos Golf = new Vehiculos("Volkswagen","Golf", 2017);
        Vehiculos Peugeot208 = new Vehiculos("Peugeot","208", 2021);
        Vehiculos Focus = new Vehiculos("Ford","Focus", 2013);

        //Asignar vehiculos a cada cliente
        cliente1.AñadirVehiculo(Hilux);
        cliente1.AñadirVehiculo(Golf);

        cliente2.AñadirVehiculo(Peugeot208);

        cliente3.AñadirVehiculo(Focus);

        //Asignar trabajos y mecanico a cada vehiculo
        Hilux.TrabajoXAuto(Frenos);
        Hilux.TrabajoXAuto(Aceite);

        Golf.TrabajoXAuto(Motor);

        Peugeot208.TrabajoXAuto(Frenos);
        Peugeot208.TrabajoXAuto(Aceite);
        Peugeot208.TrabajoXAuto(Motor);

        Focus.TrabajoXAuto(Aceite);

        //Mostrar y verificar 1 solo mecanico

        Frenos.VerificarEspecialidad(mecanico1, Servicios.PinturaCompleta);
        

        cliente1.Detalles();

        cliente2.Detalles();

        cliente3.Detalles();

    }
}