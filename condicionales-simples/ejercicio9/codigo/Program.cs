using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9___Descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO 
            double MontoPagar, Descuento = 0, Total; 
            string TipoPago;

            //PROCESO
            Console.Write("Ingrese el monto a pagar: S/");
            MontoPagar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tipo de pago (efectivo o digital): ");
            TipoPago = Console.ReadLine();

            //CALCULAR
            Total = MontoPagar;    

            //CONDICION
            if (MontoPagar >= 100.00) 
            {
                Descuento = MontoPagar * 0.15;
                Total = MontoPagar - Descuento;
            }

            //SALIDA
            Console.WriteLine("Monto a pagar: S/" + MontoPagar);
            Console.WriteLine("Monto del descuento: S/" + Descuento);
            Console.WriteLine("Total a pagar: S/" + Total);
            
            Console.ReadKey();
        }
    }
}
