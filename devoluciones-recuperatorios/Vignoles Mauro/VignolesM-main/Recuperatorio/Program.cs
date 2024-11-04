class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo {  get; set; }
    public int Año {  get; set; }

    public Vehiculo(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public void Vehiculo.MostrarDetalles()
}

class Reparacion
{
    List<string> TipoServicio { get; set; }
    List<string> TipoReparacion { get; set; }
    public int Costo {  get; set; }
    public int CostoTotal {  get; set; }

    public Reparacion(List<string> tipoServicio, List<string> tipoReparacion, int costo, int costoTotal)
    {
        TipoServicio = tipoServicio;
        TipoReparacion = tipoReparacion;
        Costo = costo;
        CostoTotal = costoTotal;
    }
}

class Mecanico
{
    public string Nombre { get; set; }
    public string Especialidad {  get; set; }

    public Mecanico(string nombre, string especialidad)
    {
        Nombre = nombre;
        Especialidad = especialidad;
    }
}

class Cliente
{
    public string Nombre { get; set; }
    public int NroCliente {  get; set; }

    public Cliente(string nombre, int nroCliente)
    {
        Nombre = nombre;
        NroCliente = nroCliente;
    }
}