using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Ingreso_y_porcentaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INCIO
            double IngresosMensuales, PorcentajeImpuesto = 0, Impuesto = 0;
            string Condicion = "No debe pagar impuesto.";

            //PROCESO
            Console.Write("Ingrese su ingreso mensual: S/");
            IngresosMensuales = Convert.ToDouble(Console.ReadLine());

            //CONDICIÓN
            if (IngresosMensuales >= 1000.00)
            {
                PorcentajeImpuesto = 11;
                Impuesto = IngresosMensuales * 0.11;
                Condicion = "Sí debe pagar impuesto.";
            }

            //SALIDA
            Console.WriteLine(Condicion);
            Console.WriteLine("Porcentaje del impuesto: " + PorcentajeImpuesto + "%");
            Console.WriteLine("Total a pagar: S/" + Impuesto);

            Console.ReadKey();
        }
    }
}
