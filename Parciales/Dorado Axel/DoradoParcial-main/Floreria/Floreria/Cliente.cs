namespace Floreria
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public Pedido pedido { get; private set; } 

        public Cliente(string Nombre, Pedido pedido) 
        {
         this.Nombre = Nombre;
         this.pedido = new Pedido();

        }
        public void MostrarDetallesPedido()
        {
           
        }


    }

    
}
