using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6___descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR
            double TotalDeCompra, Descuento, PagoFinal;

            //PROCESO
            Console.WriteLine("Introducir el total de la compra: ");
            TotalDeCompra = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            Descuento = TotalDeCompra * 0.15;
            PagoFinal = TotalDeCompra - Descuento;

            //SALIDA
            Console.WriteLine("Su descuento es de: S/" + Descuento);
            Console.WriteLine("El pago final es: S/" + PagoFinal);
        }
    }
}
