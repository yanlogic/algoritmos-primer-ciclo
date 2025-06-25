using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7___Trabajador_Horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO
            double PagoHora, MontoHorasRegulares, MontoHorasExtras = 0, TotalPagar;
            int HorasTrabajadas, HorasRegulares, HorasExtras = 0;

            //PROCESO
            Console.Write("Ingrese el total de horas trabajadas en la semana: ");
            HorasTrabajadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el pago por hora: ");
            PagoHora = Convert.ToDouble(Console.ReadLine());

            //CALCULAR
            HorasRegulares = HorasTrabajadas;
            MontoHorasRegulares = HorasTrabajadas * PagoHora;

            //CONDICIÓN
            if (HorasTrabajadas > 40)
            {
                HorasRegulares = 40;
                HorasExtras = HorasTrabajadas - HorasRegulares;
                MontoHorasRegulares = HorasRegulares * PagoHora;
                MontoHorasExtras = HorasExtras * PagoHora * 2;
            }

            //CALCULAR
            TotalPagar = MontoHorasRegulares + MontoHorasExtras;

            //SALIDA
            Console.WriteLine("Cantidad de horas regulares trabajadas: " + HorasRegulares + " horas.");
            Console.WriteLine("Cantidad de horas extras: " + HorasExtras + " horas.");
            Console.WriteLine("Monto por horas regulares: S/" + MontoHorasRegulares);
            Console.WriteLine("Monto por horas extras: S/" + MontoHorasExtras);
            Console.WriteLine("Monto total: S/" + TotalPagar);

            Console.ReadKey();
        }
    }
}
