using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Descuento_mensualidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            int PromedioGeneral;
            double Mensualidad, Descuento = 0;
            string Condicion;

            //PROCESO
            Console.Write("Ingrese su promedio de nota general: ");
            PromedioGeneral = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el monto de la mensualidad que paga: ");
            Mensualidad = Convert.ToDouble(Console.ReadLine());

            //CONDICIÓN
            if (PromedioGeneral >= 16)
            {
                Descuento = Mensualidad * 0.15;
                Condicion = "¡Felicitaciones! Logró acreditar un descuento.";
            }
            else
            {
                Descuento = 0;
                Condicion = "Lo sentimos, no logró acreditar un descuento. ¡Sigue mejorando!";
            }

            //SALIDA
            Console.Write(Condicion);

            Console.ReadKey();
        }
    }
}
