using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Tributar_impuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int PorcentajeImpuesto = 0;
            double IngresoMensual, MontoImpuesto = 0, TotalPagar;

            //PROCESO
            Console.Write("Ingrese sus ingresos mensuales: S/");
            IngresoMensual = Convert.ToDouble(Console.ReadLine());

            //CONDICIÓN
            if (IngresoMensual >= 1000)
            {
                PorcentajeImpuesto = 11;
                MontoImpuesto = IngresoMensual * 0.11;
            }
            else
            {
                PorcentajeImpuesto = 0;
                MontoImpuesto = 0;
            }

            //CALCULAR
            TotalPagar = IngresoMensual + MontoImpuesto;

            //SALIDA
            Console.WriteLine("El porcentaje del impuesto es el siguiente: " + PorcentajeImpuesto + "%");
            Console.WriteLine("El monto del impuesto es de: S/" + MontoImpuesto);
            Console.WriteLine("El total a pagar será de: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
