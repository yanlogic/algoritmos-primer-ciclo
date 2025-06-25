using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11___Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double MontoCompra, Descuento = 0, TotalPagar;
            string Dia;

            //PROCESO
            Console.Write("Ingrese el monto que está pagando: S/");
            MontoCompra = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el día de la semana en el que se realiza la compra: ");
            Dia = Console.ReadLine();

            //CONDICIÓN
            if (Dia.ToLower() == "lunes" || Dia.ToLower() == "miercoles" || Dia.ToLower() == "martes")
            {
                Descuento = MontoCompra * 0.15;
            }

            //CALCULAR
            TotalPagar = MontoCompra - Descuento;

            //SALIDA
            Console.WriteLine("Monto a pagar: S/" + MontoCompra);
            Console.WriteLine("Monto del descuento: S/" + Descuento);
            Console.WriteLine("Total a pagar: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
