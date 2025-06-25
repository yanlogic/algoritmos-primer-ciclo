using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9___Efectivo_o_digital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double MontoPagar, MontoDescuento = 0, TotalPagar;
            string TipoPago;

            //PROCESO
            Console.Write("Ingrese el monto a pagar: S/");
            MontoPagar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tipo de pago (efectivo o digital): ");
            TipoPago = Console.ReadLine();

            //CONDICIÓN
            if (MontoPagar >= 100)
            {
                MontoDescuento = MontoPagar * 0.15;
            }
            else
            {
                MontoDescuento = 0;
            }

            //CALCULAR
            TotalPagar = MontoPagar - MontoDescuento;

            //SALIDA
            Console.WriteLine("El monto a pagar será de: S/" + MontoPagar);
            Console.WriteLine("El monto del descuento: S/" + MontoDescuento);
            Console.WriteLine("El total será de: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
