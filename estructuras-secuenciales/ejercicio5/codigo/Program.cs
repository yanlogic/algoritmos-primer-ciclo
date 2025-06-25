using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___vendedor_comisión
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            double MontoConComision, MontoDeVentas, Comision;

            //PROCESO
            Console.Write("Ingrese el monto total de sus ventas del día de hoy: ");
            MontoDeVentas = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Comision = MontoDeVentas * 0.10;
            MontoConComision = MontoDeVentas + Comision;

            //SALIDA
            Console.Write("Su comisión es de: S/" + Comision);
            Console.Write(". El total que recibirá será de: S/" + MontoConComision);
        }
    }
}
