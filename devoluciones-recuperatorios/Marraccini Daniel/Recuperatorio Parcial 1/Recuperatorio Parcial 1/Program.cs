public enum Tarificacion
{
    CambioDeAceite,
    ReparacionElectrica,
    ReparacionMotor
}

interface IEditarLista<T> where T : class
{
    public void Agregar(T entidad);
    public void Quitar(T entidad);
}

class EntidadNombre
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                throw new ArgumentException("El nombre no puede quedar vacío.");
            }
            else
            {
                _nombre = value;
            }
        }
    }
    public EntidadNombre(string nombre)
    {
        Nombre = nombre;
    }
}

class Taller : EntidadNombre, IEditarLista<Mecanico>
{
    public List<Mecanico> Mecanicos { get; set; }

    public Taller(string nombre) : base(nombre)
    {
        Mecanicos = new List<Mecanico>();
    }

    public void Agregar(Mecanico mecanico)
    {
        Mecanicos.Add(mecanico);
    }

    public void Quitar(Mecanico mecanico)
    {
        if (Mecanicos.Contains(mecanico))
        {
            Console.WriteLine("El mecánico no existe.");
        }
        else
        {
            Mecanicos.Remove(mecanico);
        }
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Lista de mecánicos: \n");
        foreach(var mecanico in Mecanicos)
        {
            Console.WriteLine("Nombre del mecanico: " + mecanico.Nombre);
            Console.WriteLine("Especialidad: " + mecanico.Especialidad);
            Console.WriteLine("Clientes: \n"+);
            ;
        }
    }

    
}

class Mecanico : EntidadNombre, IEditarLista<Cliente>
{
    public Especialidad Especialidad { get; set; }
    public List<Cliente> Clientes { get; set; }

    public Mecanico(string nombre, Especialidad especialidad) : base(nombre)
    {
        Especialidad = especialidad;
        Clientes = new List<Cliente>();
    }

    public void Agregar(Cliente cliente)
    {
        Clientes.Add(cliente);
    }
    public void Quitar(Cliente cliente)
    {
        if (Clientes.Contains(cliente))
        {
            Clientes.Remove(cliente);
        }
        else
        {
            Console.WriteLine("El cliente no se encuentra en la lista.");
        }
    }
}

class Trabajo
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public decimal? Precio { get; set; }
}

class Cliente : EntidadNombre, IEditarLista<Vehiculo>
{
    private int? _idCliente;
    public int? IdCliente
    {
        get { return _idCliente; }
        set
        {
            if(value is null)
            {
                throw new ArgumentException("El ID del cliente no puede quedar vacío.");
            }
            else
            {
                _idCliente = value;
            }
        }
    }
    public decimal? Total { get; set; }
    

    public List<Vehiculo> Vehiculos { get; set; }

    public Cliente(string nombre, int? idCliente) : base(nombre)
    {
        IdCliente = idCliente; ;
        Vehiculos = new List<Vehiculo>();
    }

    public void Agregar(Vehiculo vehiculo)
    {
        Vehiculos.Add(vehiculo);
    }
    public void Quitar(Vehiculo vehiculo)
    {
        if (Vehiculos.Contains(vehiculo))
        {
            Vehiculos.Remove(vehiculo);
        }
        else
        {
            Console.WriteLine("El vehículo no se encuentra en la lista.");
        }
    }

    public void Calcular()
    {
        Total = 0;
        foreach(var vehiculo in Vehiculos)
        {
            Total += vehiculo.Precio;
        }
    }

}

class Vehiculo
{
    private string _marca;
    private string _modelo;
    private int? _ano;
    private decimal _precio;

    public string Marca
    {
        get { return _marca; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("La marca no puede quedar vacía.");
            }
            else
            {
                _marca = value;
            }
        }
    }
    public string Modelo
    {
        get { return _modelo; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El modelo no puede quedar vacío.");
            }
            else
            {
                _modelo = value;
            }
        }
    }
    public int? Ano
    {
        get { return _ano; }
        set
        {
            if (value is null)
            {
                throw new ArgumentException("El año del vehículo no puede ser nulo.");
            }
        }
    }

    public decimal Precio
    {
        get { return _precio; }
        set{
            if(value < 0)
            {
                Console.WriteLine("El precio no puede ser menor a 0.");
            }
            else
            {
                _precio = value;
            }
        }
    }

    public Cliente Cliente { get; set; }

    public Vehiculo(string marca, string modelo, int ano, Cliente cliente)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Cliente = cliente;
    }


}

class Especialidad : EntidadNombre
{
    public Especialidad(string nombre) : base(nombre) { }
}


class MainProgram()
{
    static void Main()
    {


        Console.WriteLine("\nPresione cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}
