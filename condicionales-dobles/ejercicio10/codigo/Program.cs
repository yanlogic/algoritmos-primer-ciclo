using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7___Trabajador_pago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double PagoHora, PagoExtra = 0, MontoHorasRegulares, TotalPagar;
            int HorasTrabajo, HorasRegulares = 40, HorasExtra = 0;

            //PROCESO
            Console.Write("Ingrese la cantidad de horas que ha trabajado durante la semana: ");
            HorasTrabajo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el pago por hora: S/");
            PagoHora = Convert.ToInt32(Console.ReadLine());

            //CONDICIÓN
            if (HorasTrabajo > 40)
            {
                HorasRegulares = 40;
                HorasExtra = HorasTrabajo - 40;
                PagoExtra = HorasExtra * (PagoHora * 2);
                MontoHorasRegulares = 40 * PagoHora;
            }
            else
            {
                HorasRegulares = HorasTrabajo;
                HorasExtra = 0;
                PagoExtra = 0;
                MontoHorasRegulares = HorasTrabajo * PagoHora; 
            }

            //CALCULAR
            TotalPagar = MontoHorasRegulares + PagoExtra;

            //SALIDA
            Console.WriteLine("Horas regulares trabajadas: " + HorasRegulares + " horas.");
            Console.WriteLine("Horas extras: " + HorasExtra + " horas.");
            Console.WriteLine("Monto por horas regulares: S/" + MontoHorasRegulares);
            Console.WriteLine("Monto por horas extras: S/" + PagoExtra);
            Console.WriteLine("Total que se debe pagar: S/" + TotalPagar);

            Console.ReadKey();

        }
    }
}
