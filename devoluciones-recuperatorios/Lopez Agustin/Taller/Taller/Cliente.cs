using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Cliente
    {
        List<Vehiculo> FititosList = new List<Vehiculo>();
        private int CodigoCliente;

        public Cliente(Vehiculo fitito)
        {
            FititosList.Add(fitito);
        }
        public Cliente( int codigoCliente)
        {
            CodigoCliente = codigoCliente;
        }

        public void MostrarVehiculosCliente()
        {
            Console.WriteLine($"\n");
            foreach (var item in FititosList)
            {
                Console.WriteLine($" Marca: {item.Marca}, Modelo: {item.Modelo}, Año del modelo: {item.AñoVehiculo}.\n");
            }
        }

        public void CalcularCuentaTotal()
        {
            double summer = 0;
            Console.WriteLine($"\n");
            foreach ( var vehiculo in FititosList)
            {
                foreach (double var in vehiculo.TrabajosRealizados.Values)
                {
                    summer =+ var;

                }
            }
            Console.WriteLine($"El valor necesario a pagar por éste cliente es: {summer}");
        }
    }


}
