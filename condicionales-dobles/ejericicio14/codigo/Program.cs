using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11___Tienda_días
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double Monto, MontoDescuento = 0, TotalPagar;
            string Dia;

            //PROCESO
            Console.Write("Ingrese el monto que está pagando: S/");
            Monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el día en el que se hace la compra: ");
            Dia = Console.ReadLine();

            //CONDICIÓN
            if (Dia.ToLower() == "lunes" | Dia.ToLower() == "martes" | Dia.ToLower() == "miércoles")
            {
                MontoDescuento = Monto * 0.15;
            }
            else
            {
                MontoDescuento = 0;
            }

            //CALCULAR
            TotalPagar = Monto - MontoDescuento;

            //SALIDA
            Console.WriteLine("El monto original es de: S/" + Monto);
            Console.WriteLine("El monto del descuento es de: S/" + MontoDescuento);
            Console.WriteLine("El total a pagar es de: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
