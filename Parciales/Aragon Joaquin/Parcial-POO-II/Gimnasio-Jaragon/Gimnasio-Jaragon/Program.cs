using Gimnasio_Jaragon.models;

class Program
{
    static void Main()
    {
        Gimnasio gym = new("GigaPower");

        Instructor instructor1 = new("Pepe", 7);
        Instructor instructor2 = new("Maria", 10);

        Miembro miembro1 = new("garciela");
        Miembro miembro2 = new("Manuel");

        Clase clase1 = new("Handball", instructor1, 100, 100);
        Clase clase2 = new("Futbol", instructor2, 500, 2);

        gym.AñadirClase(clase1);
        gym.AñadirClase(clase2);

        miembro1.UniseClase(clase1);
        miembro2.UniseClase(clase2);
        miembro1.UniseClase(clase2);

        //Console.WriteLine($"Lugares disponibles clase 1: {(clase1.LugaresDisponibles)}");

        gym.ObtenerInfoClases();
        clase1.MostrarInfo();
        clase2.MostrarInfo();

        //podria añadir que un mismo miembro no se pueda unir a la misma clase pero no tengo tiempo
        //miembro1.UniseClase(clase2);

    }
}