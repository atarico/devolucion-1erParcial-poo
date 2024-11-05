using Gimnasio.Models;

public class Program
{
    static void Main()
    {
        Cliente cliente1 = new Cliente("Pepe", 123);
        Cliente cliente2 = new Cliente("Martin", 321);

        Instructor instructor1 = new Instructor("Juan", 4);
        Instructor instructor2 = new Instructor("Pedro", 7);
        Instructor instructor3 = new Instructor("Jorge", 9);

        Clase clase1 = new Clase(instructor1, "Crossfit", 25, 200);
        Clase clase2 = new Clase(instructor2, "Levantamiento de pesas olimpico", 30, 150);
        Clase clase3 = new Clase(instructor3, "Yoga", 10, 300);

        cliente1.InscripcionClase(clase1);
        cliente1.InscripcionClase(clase2);

        cliente2.InscripcionClase(clase1);
        cliente2.InscripcionClase(clase2);
        cliente2.InscripcionClase(clase3);
    }
}