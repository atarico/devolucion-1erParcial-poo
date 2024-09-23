using Gimnacio.Modelos;

class Program
{
    static void Main()
    {
        Instructor instructor = new Instructor ("juan","varia");
        Clase clase1 = new Clase (instructor,10,30);
        Instructor.Add(clase1);
        clase1.ConsultarLugar();
        Miembro miembro1 = new Miembro("pablo", 1234);
        Miembro.Add(clase1);
    }
}
